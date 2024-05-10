using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime SentAt { get; set; }
        [Required]
        public bool IsRead { get; set; } = false;

        public virtual ApplicationUser Customer { get; set; }
    }
}
