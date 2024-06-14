using System.ComponentModel.DataAnnotations;

namespace EZ_Wheels.DTOs
{
    public class PasswordDTO
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string OldPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}
