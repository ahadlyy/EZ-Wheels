using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;
using EZ_Wheels.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Car_Rental_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        public CarController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{plateNumber}")]
        public IActionResult GetCarById(string plateNumber) 
        {
            Car car = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (car == null) return BadRequest();
            List<CarDataDTO> carDataDTO = 
                [
                new CarDataDTO{
                PlateNumber = car.PlateNumber,
                ChassisNumber = car.ChassisNumber,
                Make = car.Make,
                Color = car.Color,
                RentalPrice = car.RentalPrice,
                Model = car.Model,
                Variant = car.Variant,
                State = car.State,
                Transmission = car.Transmission,
                Type = car.Type,
                Mileage = car.Mileage,
                NumberOfPassengers = car.NumberOfPassengers
            }];
            ReturnDTO<CarDataDTO> returnDTO = new ReturnDTO<CarDataDTO>() {TotalCount = 1, totalResults = 1,  Data = carDataDTO };
            return Ok(returnDTO);
        }

        [HttpGet("{pageNumber},{pageSize}")]
        public IActionResult getCars(int pageNumber, int pageSize, [FromQuery] CarFilter filter)
        {
            List<CarDataDTO> carDataDTOs = _unitOfWork.CarRepo.GetCars(pageNumber, pageSize, filter);
            if (carDataDTOs == null) return BadRequest();
            ReturnDTO<CarDataDTO> returnDTO = new ReturnDTO<CarDataDTO>()
            {
                TotalCount = _unitOfWork._db.Cars.Count(),
                totalResults = carDataDTOs.Count(),
                Data = carDataDTOs
            };
            return Ok(returnDTO);
        }

        [HttpGet("{plateNumber}/reservations")]
        public IActionResult GetCarReservations(string plateNumber)
        {
            var car = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (car == null) return BadRequest();
            var reservations = car.CustomerCarRentals.ToList();
            if (reservations == null) return NotFound();
            ReturnDTO<CustomerRentCar> returnDTO = new ReturnDTO<CustomerRentCar>()
            {
                TotalCount = _unitOfWork._db.customerRentCars.Count(),
                totalResults = reservations.Count(),
                Data = reservations
            };
            return Ok(returnDTO);
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            _unitOfWork.CarRepo.Add(car);
            try
            {
                _unitOfWork.saveChanges();
            }
            catch (DbUpdateException)
            {
                if (CarExists(car.PlateNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return Created();
        }

        [HttpPut("{plateNumber}")]
        public IActionResult EditCar(string plateNumber, Car car)
        {
            if(plateNumber != car.PlateNumber)
            {
                return BadRequest();
            }
            _unitOfWork.CarRepo.update(car);
            try
            {
                _unitOfWork.saveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(plateNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{plateNumber}")]
        public IActionResult DeleteCar(string plateNumber)
        {
            var car = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (car == null)
            {
                return NotFound();
            }
            _unitOfWork.CarRepo.delete(car);
            _unitOfWork.saveChanges();
            return NoContent();
        }
        //private CarService _carService;
        //public CarController(CarService carService)
        //{
        //    _carService = carService;
        //}

        //[HttpGet]
        //public IActionResult getCars([FromQuery] int pageNumber, [FromQuery] int pageSize)
        //{
        //    List<Car> cars = _carService.getAll(pageNumber, pageSize).ToList();
        //    return Ok(cars);
        //}


        //[HttpPost("{pageNumber},{pageSize}")]
        //public IActionResult getCars( int pageNumber,  int pageSize,[FromQuery] CarFilter filter)
        //{
        //    CarDataDTO cars = _carService.getAllWithFilter(pageNumber, pageSize, filter);
        //    return Ok(cars);
        //}

        //[HttpGet("all")]
        //public IActionResult GetAll([FromQuery]int pageNumber=1,[FromQuery] int pageSize=100)
        //{
        //    List<Car> cars = _unitOfWork.CarRepo.getAll(pageNumber,pageSize).ToList();
        //    List<CarDataDTO> carDataDTOs = new List<CarDataDTO>();
        //    if (cars == null) return BadRequest();
        //    foreach(var car in cars)
        //    {
        //        carDataDTOs.Add(new CarDataDTO
        //        {
        //            PlateNumber = car.PlateNumber,
        //            ChassisNumber = car.ChassisNumber,
        //            Make = car.Make,
        //            Color = car.Color,
        //            RentalPrice = car.RentalPrice,
        //            Model = car.Model,
        //            Variant = car.Variant,
        //            State = car.State,
        //            Transmission = car.Transmission,
        //            Type = car.Type,
        //            Mileage = car.Mileage,
        //            NumberOfPassengers = car.NumberOfPassengers
        //        });
        //    }
        //    ReturnDTO<CarDataDTO> returnDTO = new ReturnDTO<CarDataDTO>()
        //    {
        //        TotalCount = _unitOfWork._db.Cars.Count(),
        //        totalResults = carDataDTOs.Count(),
        //        Data = carDataDTOs 
        //    };
        //    return Ok(returnDTO);
        //}
        private bool CarExists(string carNumber)
        {
            var d = _unitOfWork.CarRepo.getByStringId(carNumber);
            return d != null;
        }
    }
}
