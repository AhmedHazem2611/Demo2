using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTwo.DTOs;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllSales()
        {
            var sales = _unitOfWork.Sale.GetSalesWithDetails();
            var result = sales.GroupBy(s => s.EmployeeId).Select(sale => new
            {
                EmployeeId = sale.Key,
                EmployeeName = _unitOfWork.Employee.GetById(sale.Key).FullName,
                TotalRevenue = sale.Sum(s => s.SalePrice)
            }).ToList();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateSale(UpdateSaleDTO saleDTO)
        {
            Sale sale = new Sale
            {
                EmployeeId = saleDTO.EmployeeId,
                CustomerId = saleDTO.CustomerId,
                VehicleId = saleDTO.VehicleId,
                SalePrice = saleDTO.SalePrice,
                SalesDate = saleDTO.SalesDate,
                PaymentMethod = saleDTO.PaymentMethod
            };


            string status = _unitOfWork.Vehicle.GetById(sale.VehicleId).Status;
            if (status != "Available")
            {
                return BadRequest("Vehicle is already sold.");
            }
            else
            {
                _unitOfWork.Sale.Add(sale);
                _unitOfWork.Save();
                var vehicle = _unitOfWork.Vehicle.GetById(sale.VehicleId);
                vehicle.Status = "Sold";
                _unitOfWork.Vehicle.Update(vehicle);
                _unitOfWork.Save();
                return Created();
            }
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateSale(int Id, UpdateSalesDTO sale)
        {
            var saleToUpdate = _unitOfWork.Sale.GetById(Id);
            if(sale.Notes != null)
                saleToUpdate.Notes = sale.Notes;
            if(sale.PaymentMethod != null)
                saleToUpdate.PaymentMethod = sale.PaymentMethod;
            _unitOfWork.Sale.Update(saleToUpdate);
            _unitOfWork.Save();
            return NoContent();
        }

        [HttpGet("revenue")]
        public IActionResult GetTotalRevenue()
        {
            decimal totalRevenue = _unitOfWork.Sale.GetAll().Sum(e => e.SalePrice);
            return Ok(totalRevenue);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteSale(int Id)
        {
            var sale = _unitOfWork.Sale.GetById(Id);
            if (sale == null)
            {
                return NotFound();
            }
            _unitOfWork.Sale.Delete(sale);
            _unitOfWork.Save();
            var vehicle = _unitOfWork.Vehicle.GetById(sale.VehicleId);
            vehicle.Status = "Available";
            _unitOfWork.Vehicle.Update(vehicle);
            _unitOfWork.Save();
            return NoContent();
        }
    }
}
