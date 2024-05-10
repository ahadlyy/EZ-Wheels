using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Car_Rental_APIs.Models.Utilities;

namespace Car_Rental_APIs.Models
{
    public class Car
    {
        [Key]
        public string PlateNumber { get; set; }
        [Required]
        public string ChassisNumber { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int RentalPrice { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Variant { get; set; }
        public StateEnum State { get; set; } = StateEnum.Available;
        public TransmissionEnum Transmission { get; set; } = TransmissionEnum.Automatic;
        public TypeEnum Type { get; set; } = TypeEnum.Sedan;
        public int Mileage { get; set; }
        public int NumberOfPassengers { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<CustomerRentCar> CustomerCarRentals { get; set; } = new HashSet<CustomerRentCar>();
    }
}