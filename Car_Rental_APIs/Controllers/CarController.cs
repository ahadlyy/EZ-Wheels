using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }

        //[HttpGet]
        //public IActionResult getCars([FromQuery] int pageNumber, [FromQuery] int pageSize)
        //{
        //    List<Car> cars = _carService.getAll(pageNumber, pageSize).ToList();
        //    return Ok(cars);
        //}


        [HttpPost("{pageNumber},{pageSize}")]
        public IActionResult getCars( int pageNumber,  int pageSize,[FromQuery] CarFilter filter)
        {
            CarData cars = _carService.getAllWithFilter(pageNumber, pageSize, filter);
            return Ok(cars);
        }
    }
}
