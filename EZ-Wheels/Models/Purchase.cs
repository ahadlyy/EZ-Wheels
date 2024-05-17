using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.Models
{
    public class purchase
    {
        [Key]
        public int Id { get; set; }
        public string PaymentId { get; set; }
        public string PayerId { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExecutedDate { get; set; }
    }
}
