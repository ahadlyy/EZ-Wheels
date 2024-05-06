using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using static Car_Rental_APIs.Models.Utilities;

namespace Car_Rental_APIs.GenericRepo
{
    public class CarRepo : GenericRepo<Car>
    {
        
        public CarRepo(RentalDbContext db) : base(db) {}

        public CarData GetCars(int pageNumber, int pageSize, CarFilter filter)
        {
            CarData carData = new CarData();
            carData.TotalCount = _db.Cars.ToList().Count();
            var query = _db.Cars.AsQueryable();
            
            // Apply filters based on the provided criteria
            if (!string.IsNullOrEmpty(filter.Color))
            {
                query = query.Where(p => p.Color == filter.Color);
            }

            if (filter.MaxRentalPrice.HasValue)
            {
                query = query.Where(p => p.RentalPrice <= filter.MaxRentalPrice.Value);
            }

            if (filter.MinRentalPrice.HasValue)
            {
                query = query.Where(p => p.RentalPrice >= filter.MinRentalPrice.Value);
            }

            if (!string.IsNullOrEmpty(filter.Make))
            {
                query = query.Where(p => p.Make == filter.Make);
            }


            if (!string.IsNullOrEmpty(filter.Model))
            {
                query = query.Where(p => p.Model.Contains(filter.Model));
            }

            if (!string.IsNullOrEmpty(filter.Variant))
            {
                query = query.Where(p => p.Variant.Contains(filter.Variant));
            }

            if (filter.NumberOfPassengers.HasValue)
            {
                query = query.Where(p => p.NumberOfPassengers == filter.NumberOfPassengers.Value);
            }

            if (!string.IsNullOrEmpty(filter.State))
            {
                Object res;
                StateEnum state;
                if (!Enum.TryParse(typeof(StateEnum), filter.State, true, out res))
                    throw new Exception("State value is not valid");
                state=(StateEnum)res;
                query = query.Where(p => p.State == state);
            }
            if (!string.IsNullOrEmpty(filter.Transmission))
            {
                Object res;
                TransmissionEnum state;
                if (!Enum.TryParse(typeof(TransmissionEnum), filter.Transmission, true, out res))
                    throw new Exception("Transmission value is not valid");
                state = (TransmissionEnum)res;
                query = query.Where(p => p.Transmission == state);
            }
            if (!string.IsNullOrEmpty(filter.Type))
            {
                Object res;
                TypeEnum state;
                if (!Enum.TryParse(typeof(TypeEnum), filter.Type, true, out res))
                    throw new Exception("Type value is not valid");
                state = (TypeEnum)res;
                query = query.Where(p => p.Type == state);
            }
            
            carData.cars = getAll(pageNumber, pageSize, query.ToList());
            carData.totalResults = carData.cars.Count();



            return carData;
        }



    }
}
