using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;
using EZ_Wheels.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Car_Rental_APIs.Models.Utilities;

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
                State = car.State.ToString(),
                Transmission = car.Transmission.ToString(),
                Type = car.Type.ToString(),
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
        [HttpGet("colors")]
        public IActionResult GetCarColors(int pageNumber=1, int pageSize=50)
        {
            var uniqueColors = _unitOfWork.CarRepo.getAll(pageNumber, pageSize)
                .Select(car => car.Color)
                .Distinct()
                .ToList();
            if(uniqueColors == null)
            {
                return BadRequest();
            }
            ReturnDTO<string> returnDTO = new ReturnDTO<string>() 
            {
                TotalCount = uniqueColors.Count(),
                totalResults = uniqueColors.Count(),
                Data = uniqueColors
            };

            return Ok(returnDTO);
        }

        [HttpGet("make")]
        public IActionResult GetCarMakes(int pageNumber = 1, int pageSize = 50)
        {
            var uniqueMakes = _unitOfWork.CarRepo.getAll(pageNumber, pageSize)
                .Select(car => car.Make)
                .Distinct()
                .ToList();
            if (uniqueMakes == null)
            {
                return BadRequest();
            }
            ReturnDTO<string> returnDTO = new ReturnDTO<string>()
            {
                TotalCount = uniqueMakes.Count(),
                totalResults = uniqueMakes.Count(),
                Data = uniqueMakes
            };

            return Ok(returnDTO);
        }

        [HttpPost]
        public IActionResult AddCar([FromBody]CarDataDTO car)
        {
            //if (car.Photo == null || car.Photo.Length == 0)
            //{
            //    return BadRequest("No photo uploaded.");
            //}
            //string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            //string uniqueFileName = Guid.NewGuid().ToString() + "_" + car.Photo.FileName;
            //string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            //using (var stream = new FileStream(filePath, FileMode.Create))
            //{
            //    await car.Photo.CopyToAsync(stream);
            //}
            //car.PhotoUrl = "/uploads/" + uniqueFileName;
            Object res;
            TransmissionEnum trans;
            if (!Enum.TryParse(typeof(TransmissionEnum), car.Transmission, true, out res))
                return BadRequest();
            trans = (TransmissionEnum)res;

            Object res2;
            TypeEnum state;
            if (!Enum.TryParse(typeof(TypeEnum), car.Type, true, out res2))
                return BadRequest();
            state = (TypeEnum)res;

            Car newCar = new Car()
            {
                PlateNumber = car.PlateNumber,
                ChassisNumber = car.ChassisNumber,
                Make = car.Make,
                Color = car.Color,
                RentalPrice = car.RentalPrice.Value,
                Model = car.Model,
                Variant = car.Variant,
                Transmission = trans,
                Type = state,
                Mileage = car.Mileage.Value,
                NumberOfPassengers = car.NumberOfPassengers.Value,
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
            return Created("",newCar);
        }

        [HttpPut("{plateNumber}")]
        public  IActionResult EditCar(string plateNumber, [FromBody] CarDataDTO car)
        {
            Car existingCar = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (existingCar == null)
            {
                return NotFound();
            }

            Object res;
            TransmissionEnum trans;
            if (Enum.TryParse(typeof(TransmissionEnum), car.Transmission, true, out res))
            {
                trans = (TransmissionEnum)res;
                existingCar.Transmission = trans;
            }
            

            Object res2;
            TypeEnum type;
            if (Enum.TryParse(typeof(TypeEnum), car.Type, true, out res2))
            {
                type = (TypeEnum)res2;
                existingCar.Type = type;
            }
                
            

            Object res3;
            StateEnum state;
            if (Enum.TryParse(typeof(StateEnum), car.State, true, out res3))
            {
                state = (StateEnum)res3;
                existingCar.State = state;
            }  
            

            if(car.ChassisNumber != null) existingCar.ChassisNumber = car.ChassisNumber;
            if (car.Make != null) existingCar.Make = car.Make;
            if (car.Color != null) existingCar.Color = car.Color;
            if (car.RentalPrice != null) existingCar.RentalPrice = car.RentalPrice.Value;
            if (car.Model != null) existingCar.Model = car.Model;
            if (car.Mileage != null) existingCar.Mileage = car.Mileage.Value;
            if (car.NumberOfPassengers != null) existingCar.NumberOfPassengers = car.NumberOfPassengers.Value;

            // Check if a new photo is provided
            //if (car.Photo != null && car.Photo.Length > 0)
            //{
            //    // Save the uploaded photo to the server
            //    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            //    string uniqueFileName = Guid.NewGuid().ToString() + "_" + car.Photo.FileName;
            //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            //    using (var stream = new FileStream(filePath, FileMode.Create))
            //    {
            //        await car.Photo.CopyToAsync(stream);
            //    }

            //    var oldPhotoUrl = _unitOfWork.CarRepo.getByStringId(plateNumber)?.PhotoUrl;
            //    if (oldPhotoUrl != null)
            //    {
            //        string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, oldPhotoUrl.TrimStart('/'));
            //        if (System.IO.File.Exists(oldFilePath))
            //        {
            //            System.IO.File.Delete(oldFilePath);
            //        }
            //    }
            //    // Delete the old photo if it exists
                
            //    // Update the photo URL in the DTO
            //    existingCar.PhotoUrl = "https://localhost:7108/uploads/" + uniqueFileName;
            //}


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

        [HttpPost("photo")]
        public async  Task<IActionResult> uploadPhoto(string plateNumber,IFormFile photo)
        {
            Car existingCar = _unitOfWork.CarRepo.getByStringId(plateNumber);
            if (existingCar == null) return NotFound();
            // Check if a new photo is provided
            if (photo != null && photo.Length > 0)
            {
                // Save the uploaded photo to the server
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                var oldPhotoUrl = _unitOfWork.CarRepo.getByStringId(plateNumber)?.PhotoUrl;
                if (oldPhotoUrl != null)
                {
                    string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, oldPhotoUrl.TrimStart('/'));
                    if (System.IO.File.Exists(oldFilePath))
                    {
                        System.IO.File.Delete(oldFilePath);
                    }
                }
                // Delete the old photo if it exists

                // Update the photo URL in the DTO
                existingCar.PhotoUrl = "https://localhost:7108/uploads/" + uniqueFileName;
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

                return Ok();
            }
            return BadRequest();
        }
        private bool CarExists(string carNumber)
        {
            var d = _unitOfWork.CarRepo.getByStringId(carNumber);
            return d != null;
        }


    }
}
