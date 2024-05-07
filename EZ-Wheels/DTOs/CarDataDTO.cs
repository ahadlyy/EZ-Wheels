using Car_Rental_APIs.Models;

namespace Car_Rental_APIs.DTOs
{
    public class CarDataDTO
    {
        public int TotalCount { get; set; }
        public int totalResults { get; set; }
        public string userMessage { get; set; }
        public IEnumerable<Car> cars { get; set; }

        
    }
}
