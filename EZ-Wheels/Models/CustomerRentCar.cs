using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_APIs.Models
{
    public class CustomerRentCar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        [Required]
        public bool isInProgress { get; set; } = true;
        [Required]
        public bool isOnlinePaid { get; set; } = false;
        [Required]
        public float totalRentPrice { get; set; }
        public int numberofRentDays { get; set; }

        public virtual ApplicationUser Customer { get; set; }
        public virtual Car CustomerCar { get; set; }
    }
}