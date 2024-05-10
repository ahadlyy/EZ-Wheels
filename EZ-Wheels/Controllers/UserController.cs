using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using EZ_Wheels.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EZ_Wheels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> getByRole([FromQuery]string role)
        {
            var fetchedUsersRaw = await _userManager.GetUsersInRoleAsync(role);

            if (fetchedUsersRaw.Count == 0)
                return NoContent();

            List<UserDTO> fetchedUsers = [];
            foreach (var user in fetchedUsersRaw)
            {
                fetchedUsers.Add(new UserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email
                });
            }
            return Ok(fetchedUsers);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> getById(int? id)
        {
            if (id == null)
                return BadRequest();
            var fetchedUserRaw = await _userManager.FindByIdAsync(id.ToString());
            if (fetchedUserRaw == null)
                return NotFound();
            else
            {
                UserDTO fetchedUser = new UserDTO
                {
                    Id = fetchedUserRaw.Id,
                    UserName = fetchedUserRaw.UserName,
                    Email = fetchedUserRaw.Email
                };
                return Ok(fetchedUser);
            }
        }

        [HttpPost]
        public async Task<IActionResult> add(RegisterUserDto userToAdd)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ApplicationUser newUser = new ApplicationUser();
            var lastUserId = await _userManager.Users.OrderByDescending(u => u.Id)
                                                         .Select(u => u.Id)
                                                         .FirstOrDefaultAsync();
            if (lastUserId == null) { lastUserId = "0"; }

            newUser.Id = (int.Parse(lastUserId) + 1).ToString();
            newUser.UserName = userToAdd.UserName;
            newUser.NormalizedUserName = userToAdd.UserName.ToUpper();
            newUser.Email = userToAdd.Email;
            newUser.NormalizedEmail = userToAdd.Email.ToUpper();

            var role = await _roleManager.FindByNameAsync("Employee");

            IdentityResult result = await _userManager.CreateAsync(newUser, userToAdd.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, role.Name);
                return Ok("Account added successfully");
            }

            var errorMessages = new List<string>();

            foreach (var error in result.Errors)
            {
                errorMessages.Add(error.Description);
            }
            return BadRequest(errorMessages);
        }

        [HttpPut]
        public async Task<IActionResult> update(RegisterUserDto userToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var fetchedUser = await _userManager.FindByNameAsync(userToUpdate.UserName);
            if (fetchedUser == null)
                return NotFound();

            fetchedUser.Email = userToUpdate.Email;
            fetchedUser.NormalizedEmail = userToUpdate.Email.ToUpper();
            fetchedUser.UserName = userToUpdate.UserName;
            fetchedUser.NormalizedUserName = userToUpdate.UserName.ToUpper();
            fetchedUser.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(fetchedUser, userToUpdate.Password);

            var updatedUser = await _userManager.UpdateAsync(fetchedUser);

            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var userToDelete = await _userManager.FindByIdAsync(id.ToString());
            if(userToDelete == null)
                return NotFound();
            await _userManager.DeleteAsync(userToDelete);
            return Ok();
        }
    }
}