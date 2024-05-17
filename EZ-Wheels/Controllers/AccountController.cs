using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using EZ_Wheels.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Car_Rental_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
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
                return Unauthorized(new { message="Incorrect password" });

            ///claims token
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, fetchedUser.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, fetchedUser.Id));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

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
    }
}