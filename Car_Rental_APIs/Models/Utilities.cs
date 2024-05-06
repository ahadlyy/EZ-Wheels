namespace Car_Rental_APIs.Models
{
    public class Utilities
    {
        public enum StateEnum
        {
            Available,
            Maintenance,
            Rented
        }

        public enum TransmissionEnum
        {
            Manual,
            Automatic
        }

        public enum TypeEnum
        {
            SUV,
            Sedan,
            Hatchback,
            Crossover,
            Van,
            Sports,
            Hybrid,
            Electric,
            Convertible
        }
    }
}