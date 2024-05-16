using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
          //ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }

        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Range(18, 65, ErrorMessage = "The age must be between 18 and 65 years old.")]
        public int Age { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
