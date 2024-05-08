﻿using Car_Rental_APIs.DTOs;
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
        IWebHostEnvironment _hostingEnvironment;
        public CarController(UnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
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
                NumberOfPassengers = car.NumberOfPassengers,
                PhotoUrl = car.PhotoUrl
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
        public async Task<IActionResult> AddCar([FromForm] CarDataDTO car)
        {
            if (car.Photo == null || car.Photo.Length == 0)
            {
                return BadRequest("No photo uploaded.");
            }
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + car.Photo.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await car.Photo.CopyToAsync(stream);
            }
            car.PhotoUrl = "/uploads/" + uniqueFileName;
            Car newCar = new Car() 
            {
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
                NumberOfPassengers = car.NumberOfPassengers,
                PhotoUrl = car.PhotoUrl
            };
            _unitOfWork.CarRepo.Add(newCar);
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
        public async Task<IActionResult> EditCar(string plateNumber, [FromForm] CarDataDTO car)
        {
            if (plateNumber != car.PlateNumber)
            {
                return BadRequest();
            }
            Car existingCar = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (existingCar == null)
            {
                return NotFound();
            }

            existingCar.ChassisNumber = car.ChassisNumber;
            existingCar.Make = car.Make;
            existingCar.Color = car.Color;
            existingCar.RentalPrice = car.RentalPrice;
            existingCar.Model = car.Model;
            existingCar.Variant = car.Variant;
            existingCar.State = car.State;
            existingCar.Transmission = car.Transmission;
            existingCar.Type = car.Type;
            existingCar.Mileage = car.Mileage;
            existingCar.NumberOfPassengers = car.NumberOfPassengers;
            // Check if a new photo is provided
            if (car.Photo != null && car.Photo.Length > 0)
            {
                // Save the uploaded photo to the server
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + car.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await car.Photo.CopyToAsync(stream);
                }

                // Delete the old photo if it exists
                string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, _unitOfWork.CarRepo.getByStringId(plateNumber).PhotoUrl.TrimStart('/'));
                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }
                // Update the photo URL in the DTO
                existingCar.PhotoUrl = "/uploads/" + uniqueFileName;
            }


            _unitOfWork.CarRepo.update(existingCar);

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
