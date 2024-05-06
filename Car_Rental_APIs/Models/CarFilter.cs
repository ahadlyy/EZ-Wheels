using System.Diagnostics.CodeAnalysis;
using static Car_Rental_APIs.Models.Utilities;

namespace Car_Rental_APIs.Models
{
    public class CarFilter
    {
        [AllowNull]
        public string? Make { get; set; }
        public string? Color { get; set; }
        public int? MaxRentalPrice { get; set; }
        public int? MinRentalPrice { get; set; }
        public string? Model { get; set; }
        public string? Variant { get; set; }

        public int? NumberOfPassengers { get; set; }
        public string? State { get; set; } 
        public string? Transmission { get; set; } 
        public string? Type { get; set; } 

        
    }
}
