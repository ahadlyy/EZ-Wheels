using Car_Rental_APIs.DTOs;
using Car_Rental_APIs.Models;
using Car_Rental_APIs.UnitOfWorks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        private UserManager<ApplicationUser> _userManager;
        public RentController(UnitOfWork unitOfWork,UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [HttpGet("{pageNumber},{pageSize}")]
        public IActionResult getAll(int pageNumber=1, int pageSize=100)
        {

            var data = _unitOfWork.CustomerRentCarRepo.getAll(pageNumber, pageSize).ToList();
            List<CustomerRentCarDTO> customerRentCarDTOList = new List<CustomerRentCarDTO>();
            foreach (var item in data)
            {
                var dto = getCarRentDTO(item);
                customerRentCarDTOList.Add(dto);
            }
            ReturnDTO<CustomerRentCarDTO> returnDTO = new ReturnDTO<CustomerRentCarDTO>();
            returnDTO.Data = customerRentCarDTOList;
            returnDTO.totalResults = customerRentCarDTOList.Count();
            returnDTO.TotalCount = _unitOfWork._db.customerRentCars.Count();
            return Ok(returnDTO);
        }

        [HttpGet("{id}")]
        public IActionResult getById(string id)
        {
            var rent=_unitOfWork.CustomerRentCarRepo.getByStringId(id);
            if (rent == null) return BadRequest();
            var dto = getCarRentDTO(rent);
            ReturnDTO<CustomerRentCarDTO> returnDTO = new ReturnDTO<CustomerRentCarDTO>();
            returnDTO.totalResults = 1;
            var res = new List<CustomerRentCarDTO>() { dto };
            returnDTO.Data=res;
            return Ok(returnDTO);
        }

        [HttpPost]
        async public Task<IActionResult> Add(CustomerRentCarDTO dto)
        {
            var res = await getCustomerRentCarModel(dto);
            if(res == null) return BadRequest();
            
            _unitOfWork.CustomerRentCarRepo.Add(res);
            _unitOfWork.saveChanges();
            return Created();
        }

        [HttpPatch]
        async public Task<IActionResult> Update(CustomerRentCarDTO dto)
        {
            var rent = await getCustomerRentCarModel(dto);
            if (rent == null) return BadRequest();
             _unitOfWork.CustomerRentCarRepo.update(rent);
            _unitOfWork.saveChanges();
            return Ok(rent);
        }
        [HttpDelete]
        public IActionResult Delete(string id) {
            var rent = _unitOfWork.CustomerRentCarRepo.getByStringId(id);
            if (rent == null) return BadRequest();
            _unitOfWork.CustomerRentCarRepo.delete(rent);
            _unitOfWork.saveChanges();
            return Ok();
        }


        private CustomerRentCarDTO getCarRentDTO(CustomerRentCar c) {
            CustomerRentCarDTO dto = new CustomerRentCarDTO();
            dto.ReservationNumber = c.ReservationNumber;
            dto.StartingDate = c.StartingDate;
            dto.EndingDate = c.EndingDate;
            dto.PickUpLatitude = c.PickUpLatitude;
            dto.PickUpLongitude = c.PickUpLongitude;
            dto.DropOffLongitude = c.DropOffLongitude;
            dto.DropOffLatitude = c.DropOffLatitude;
            dto.CustomerName = c?.Customer?.UserName;
            dto.PlateNumber = c?.CustomerCar?.PlateNumber;
            dto.Make = c?.CustomerCar?.Make;
            dto.Model = c?.CustomerCar?.Model;
            dto.numberofRentDays = (int) (dto.EndingDate - dto.StartingDate).TotalDays;
            if(c.CustomerCar == null)
            {
                dto.totalRentPrice = 0;
            }
            else
            {
                dto.totalRentPrice = dto.numberofRentDays * c.CustomerCar.RentalPrice;
            }
            return dto;
        }

        async private Task<CustomerRentCar>  getCustomerRentCarModel(CustomerRentCarDTO dto)
        {
            CustomerRentCar rent = new CustomerRentCar();
            rent.ReservationNumber = dto.ReservationNumber;
            rent.StartingDate = dto.StartingDate;
            rent.EndingDate = dto.EndingDate;
            rent.PickUpLatitude = dto.PickUpLatitude;
            rent.PickUpLongitude = dto.PickUpLongitude;
            rent.DropOffLongitude = dto.DropOffLongitude;
            rent.DropOffLatitude = dto.DropOffLatitude;
            rent.isOnlinePaid = dto.isOnlinePaid;
            rent.numberofRentDays = dto.numberofRentDays;
            var user =await _userManager.FindByIdAsync(dto.CustomerId);
            if(user != null)
            {
                rent.Customer = user;
            }
            var car = _unitOfWork.CarRepo.getByStringId(dto.PlateNumber); 
            if(car != null)
            {
                rent.CustomerCar = car;
            }
            return rent;
        }

    }
}
