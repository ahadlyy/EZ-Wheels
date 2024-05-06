using Car_Rental_APIs.DTOs;
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

     

        public CarData getAllWithFilter(int pageNumber, int pageSize,CarFilter filter) {
            var cars = _unitOfWork.CarRepo.GetCars(pageNumber, pageSize, filter);
            return cars;
        }
    }
}
