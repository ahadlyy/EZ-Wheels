namespace Car_Rental_APIs.DTOs
{
    public class ReturnDTO<T> where T : class
    {
        public int TotalCount { get; set; }
        public int totalResults { get; set; }
        public string userMessage { get; set; } = string.Empty;
        public IEnumerable<T> Data { get; set; }
    }
}
