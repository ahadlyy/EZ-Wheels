using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.DTOs
{
    public class CustomerRentCarDTO
    {
        [Required]
        public string ReservationNumber { get; set; }
        [Required]
        public DateTime StartingDate { get; set; }
        [Required]
        public DateTime EndingDate { get; set; }
        [Required]
        public double PickUpLatitude { get; set; }
        [Required]
        public double PickUpLongitude { get; set; }
        [Required]
        public double DropOffLatitude { get; set; }
        [Required]
        public double DropOffLongitude { get; set; }


        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
     
        public string? PlateNumber { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
    }
}
