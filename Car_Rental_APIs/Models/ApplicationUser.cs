using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Range(18, 65, ErrorMessage = "The age must be between 18 and 65 years old.")]
        public int Age { get; set; }
        public virtual ICollection<CustomerRentCar> CustomerCarRentals { get; set; } = new HashSet<CustomerRentCar>();
    }
}
