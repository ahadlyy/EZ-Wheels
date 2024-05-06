using Car_Rental_APIs.Models;

namespace Car_Rental_APIs.DTOs
{
    public class CarData
    {
        public int TotalCount { get; set; }
        public int totalResults { get; set; }
        public IEnumerable<Car> cars { get; set; }
    }
}
