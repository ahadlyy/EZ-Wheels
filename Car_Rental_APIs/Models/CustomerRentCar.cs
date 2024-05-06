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

        public virtual ApplicationUser Customer { get; set; }
        public virtual Car CustomerCar { get; set; }
    }
}
