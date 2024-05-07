using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.DTOs
{
    public class LoginUserDto
    {
        [Required]

        public string UserName { get; set; }

        [Required]
        //[MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        //  ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }
    }
}
