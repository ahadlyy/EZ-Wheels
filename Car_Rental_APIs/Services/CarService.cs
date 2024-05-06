using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Car_Rental_APIs.Services
{
    public class CarService
    {
        private UnitOfWork _unitOfWork;
        public CarService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Car> getAll(int pageNumber, int pageSize)
        {
            var cars = _unitOfWork.CarRepo.getAllQuery(pageNumber, pageSize);
            return cars;
        }
    }
}

// var query = _articles.Tolist();
//        var totalCount = query.Count();
//        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
//        query = query.Skip((page - 1) * pageSize).Take(pageSize);
//    }
//return Ok(query);


