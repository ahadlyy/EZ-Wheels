using Car_Rental_APIs.Models;
using static Car_Rental_APIs.Models.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_APIs.DTOs
{
    public class CarDataDTO
    {
        public string PlateNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public int? RentalPrice { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public string State { get; set; } ="Available";
        public string Transmission { get; set; } 
        public string Type { get; set; } 
        public int? Mileage { get; set; }
        public int? NumberOfPassengers { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoUrl { get; set; }
    }
}
