using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using EZ_Wheels.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Car_Rental_APIs.Controllers
{

    public class ApiResponseDto
    {
        public DataDto Data { get; set; }
    }

    public class DataDto
    {
        public string Auth_token { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        /* Start of : variables to integrate qwith auth gate */
        private readonly HttpClient _httpClient;
        private readonly string apiUrl = "http://localhost:3000/auth/authcode";
        /* End of : variables to integrate with auth gate */


        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration config, HttpClient httpClient)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
            _httpClient = httpClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Registration(RegisterUserDto userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ApplicationUser newUser = new ApplicationUser();
            var lastUserId = await _userManager.Users.OrderByDescending(u => u.Id)
                                                         .Select(u => u.Id)
                                                         .FirstOrDefaultAsync();
            if (lastUserId == null) { lastUserId = "0"; }

            newUser.Id = (int.Parse(lastUserId) + 1).ToString();
            newUser.UserName = userDto.UserName;
            newUser.NormalizedUserName = userDto.UserName.ToUpper();
            newUser.Email = userDto.Email;
            newUser.NormalizedEmail = userDto.Email.ToUpper();
            newUser.Age = userDto.Age;
            newUser.PhoneNumber = userDto.PhoneNumber;

            var role = await _roleManager.FindByNameAsync("Client");

            IdentityResult result = await _userManager.CreateAsync(newUser, userDto.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, role.Name);
                return Ok();
            }

            var errorMessages = new List<string>();

            foreach (var error in result.Errors)
            {
                errorMessages.Add(error.Description);
            }
            return BadRequest(errorMessages);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            ApplicationUser fetchedUser = await _userManager.FindByNameAsync(userDto.UserName);
            if (fetchedUser == null)
                return Unauthorized(new { message = "User does not exist" });

            bool isPasswordCorrect = await _userManager.CheckPasswordAsync(fetchedUser, userDto.Password);
            if (!isPasswordCorrect)
                return Unauthorized(new { message = "Incorrect password" });

            ///claims token
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, fetchedUser.UserName),
                new(ClaimTypes.NameIdentifier, fetchedUser.Id),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            //role
            var roles = await _userManager.GetRolesAsync(fetchedUser);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
                claims.Add(new Claim("role", role));
            }

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));

            SigningCredentials signincred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken mytoken =
                new JwtSecurityToken(
                        issuer: _config["JWT:ValidIssuer"],  //url web api 
                        audience: _config["JWT:ValidAudiance"], //url consumer angular
                        claims: claims,
                        expires: DateTime.Now.AddHours(5),
                        signingCredentials: signincred
                        );

            UserDTO returnedUser = new UserDTO
            {
                Id = fetchedUser.Id,
                Email = fetchedUser.Email,
                PhoneNumber = fetchedUser.PhoneNumber,
                UserName = fetchedUser.UserName,
                Age = fetchedUser.Age,
            };

            return Ok(
                new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(mytoken),
                    expiration = mytoken.ValidTo,
                    user = returnedUser
                });
        }


        /* ---------------------- Auth gate integration Section ---------------------- */
        [HttpPost("codeWithToken")]
        public async Task<IActionResult> ExchangeCodeWithToken(AuthCodeDto authCodeDto)
        {
            var data = new
            {
                authCode = authCodeDto.AuthCode
            };

            var jsonData = JsonConvert.SerializeObject(data);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseDto>(jsonResponse);

                if (apiResponse != null && apiResponse.Data != null)
                {
                    string token = apiResponse.Data.Auth_token;
                    var handler = new JwtSecurityTokenHandler();
                    var jwtSecurityToken = handler.ReadJwtToken(token);
                    AuthgateUserDto authgateUser = ExtractUserInfoFromToken(jwtSecurityToken);
                    bool isExistingUser = await IsExistingUser(authgateUser);
                    
                    if (!isExistingUser)
                        await RegisterAuthgateUser(authgateUser);

                    JwtDto returnedJwtDto = await LoginAuthgateUser(authgateUser);

                    return Ok(returnedJwtDto);
                }
                else
                {
                    return BadRequest("Invalid response format");
                }
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private AuthgateUserDto ExtractUserInfoFromToken(JwtSecurityToken token)
        {
            AuthgateUserDto authgateUser = new()
            {
                Email = token.Claims.First(claim => claim.Type == "email").Value,
                UserName = token.Claims.First(claim => claim.Type == "name").Value,
                PhoneNumber = token.Claims.First(claim => claim.Type == "phone").Value,
                Image = token.Claims.First(claim => claim.Type == "image").Value,
                Age = token.Claims.First(claim => claim.Type == "age").Value,
            };

            return authgateUser;
        }

        private async Task<bool> RegisterAuthgateUser(AuthgateUserDto authgateUser)
        {
            ApplicationUser newUser = new();
            var lastUserId = await _userManager.Users.OrderByDescending(u => u.Id)
                                                         .Select(u => u.Id)
                                                         .FirstOrDefaultAsync();
            lastUserId ??= "0";

            newUser.Id = (int.Parse(lastUserId) + 1).ToString();
            newUser.UserName = authgateUser.UserName;
            newUser.NormalizedUserName = authgateUser.UserName.ToUpper();
            newUser.Email = authgateUser.Email;
            newUser.NormalizedEmail = authgateUser.Email.ToUpper();
            newUser.Age = int.Parse(authgateUser.Age);
            newUser.PhoneNumber = authgateUser.PhoneNumber;

            // var role = await _roleManager.FindByNameAsync("Client");

            IdentityResult result = await _userManager.CreateAsync(newUser, "Password123!");
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, "Client");
                return true;
            }
            return false;
        }

        private async Task<JwtDto> LoginAuthgateUser(AuthgateUserDto authgateUse)
        {
            ApplicationUser fetchedUser = await _userManager.FindByEmailAsync(authgateUse.Email);

            var claims = new List<Claim>();

            var roles = await _userManager.GetRolesAsync(fetchedUser);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, fetchedUser.Id));
                claims.Add(new Claim(ClaimTypes.Role, role));
                claims.Add(new Claim("id", fetchedUser.Id));
                claims.Add(new Claim("role", role));
                claims.Add(new Claim("email", fetchedUser.Email));
                claims.Add(new Claim("userName", fetchedUser.Id));
                claims.Add(new Claim("age", fetchedUser.Id));
                claims.Add(new Claim("phoneNumber", fetchedUser.Id));
                
            }

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));

            SigningCredentials signincred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken mytoken =
                new JwtSecurityToken(
                        // issuer: _config["JWT:ValidIssuer"],  //url web api 
                        // audience: _config["JWT:ValidAudiance"], //url consumer angular
                        claims: claims,
                        expires: DateTime.Now.AddHours(5),
                        signingCredentials: signincred
                        );

            JwtDto returnedJwtDto = new()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(mytoken),
            };

            return returnedJwtDto;
        }

        private async Task<bool> IsExistingUser(AuthgateUserDto authgateUser)
        {
            ApplicationUser fetchedUser = await _userManager.FindByEmailAsync(authgateUser.Email);
            if (fetchedUser == null)
                return false;
            else
                return true;
        }

        /* ------------------------------------------------------------------------------------ */
    }
}