using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTwo.DTOs;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _unitOfWork.Vehicle.GetAvailableVehicles().OrderByDescending(v => v.Year).ToList();
            List<VehicleDTO> vehicleDTOs = new List<VehicleDTO>();
            foreach (var vehicle in vehicles)
            {
                vehicleDTOs.Add(new VehicleDTO
                {
                    Id = vehicle.Id,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Price = vehicle.Price,
                    Status = vehicle.Status,
                    CategoryId = vehicle.CategoryId
                });
            }
            return Ok(vehicleDTOs);
        }
        [HttpPost]
        public IActionResult CreateVehicle(CreateVehicleDTO vehicleDTO)
        {
            var vehicle = new Vehicle
            {
                Make = vehicleDTO.Make,
                Model = vehicleDTO.Model,
                Year = vehicleDTO.Year,
                Price = vehicleDTO.Price,
                Status = "Available",
                CategoryId = vehicleDTO.CategoryId,
                VIN = vehicleDTO.VIN,
                FuelType = vehicleDTO.FuelType,
                Color = vehicleDTO.Color,
                Mileage = vehicleDTO.Mileage,
                Transmission = vehicleDTO.Transmission
            };

            bool vinNotUnique = _unitOfWork.Vehicle.GetAll().Any(e => e.VIN == vehicle.VIN);
            if (vinNotUnique || vehicle.Price < 0)
            {
                return BadRequest("VIN must be unique.");
            }
            _unitOfWork.Vehicle.Add(vehicle);
            _unitOfWork.Save();
            return Created();
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteVehicle(int Id)
        {
            var vehicle = _unitOfWork.Vehicle.GetById(Id);
            if (vehicle == null)
            {
                return NotFound();
            }
            if (vehicle.Status == "Sold")
            {
                return BadRequest("Cannot delete a sold vehicle.");
            }
            _unitOfWork.Vehicle.Delete(vehicle);
            _unitOfWork.Save();
            return NoContent();
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateVehicle(int Id, UpdateVehicleDTO vehicleDTO)
        {
            var vehicleToUpdate = _unitOfWork.Vehicle.GetById(Id);
            if (vehicleToUpdate == null)
            {
                return NotFound();
            }
            if (vehicleDTO.Price < 0)
            {
                return BadRequest("Price cannot be negative.");
            }
            var category = _unitOfWork.Category.GetById(vehicleDTO.CategoryId.Value);
            if (vehicleDTO.CategoryId != null && category != null)
            {
                vehicleToUpdate.CategoryId = vehicleDTO.CategoryId.Value;
            }
            if (vehicleDTO.Price != null)
            {
                vehicleToUpdate.Price = vehicleDTO.Price.Value;
            }
            return NoContent();
        }

        [HttpGet("available-vehicles")]
        public IActionResult GetAvailableVehicles()
        {
            var vehicles = _unitOfWork.Vehicle.GetAvailableVehicles().ToList();
            List<VehicleDTO> vehicleDTOs = new List<VehicleDTO>();
            foreach (var vehicle in vehicles)
            {
                vehicleDTOs.Add(new VehicleDTO
                {
                    Id = vehicle.Id,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Price = vehicle.Price,
                    Status = vehicle.Status,
                    CategoryId = vehicle.CategoryId
                });
            }
            return Ok(vehicleDTOs);
        }
        [HttpGet("sold-vehicles")]
        public IActionResult GetSoldVehicles()
        {
            var vehicles = _unitOfWork.Vehicle.GetSoldVehicles().ToList();
            List<VehicleDTO> vehicleDTOs = new List<VehicleDTO>();
            foreach (var vehicle in vehicles)
            {
                vehicleDTOs.Add(new VehicleDTO
                {
                    Id = vehicle.Id,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Price = vehicle.Price,
                    Status = vehicle.Status,
                    CategoryId = vehicle.CategoryId
                });
            }
            return Ok(vehicleDTOs);
        }
    
        [HttpGet("category/{categoryName}")]
        public IActionResult GetVehiclesByCategory(string categoryName)
        {
            var vehicles = _unitOfWork.Vehicle.GetVehiclesByCategory(categoryName).ToList();
            if (!vehicles.Any())
            {
                return NotFound($"No vehicles found for category: {categoryName}");
            }
            List<VehicleDTO> vehicleDTOs = new List<VehicleDTO>();
            foreach (var vehicle in vehicles)
            {
                vehicleDTOs.Add(new VehicleDTO
                {
                    Id = vehicle.Id,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Price = vehicle.Price,
                    Status = vehicle.Status,
                    CategoryId = vehicle.CategoryId
                });
            }
            return Ok(vehicleDTOs);
        }
    }
}
