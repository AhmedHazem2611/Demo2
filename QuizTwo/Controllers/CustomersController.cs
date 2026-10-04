using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTwo.DTOs;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("{Id}")]
        public IActionResult GetCustomerById(int Id)
        {
            var customer = _unitOfWork.Customer.GetById(Id);
            CustomerDTO customerDTO = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                DriverLicenseNumber = customer.DriverLicenseNumber,
                CustomerProfileId = customer.CustomerProfileId
            };
            return Ok(customerDTO);
        }
        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerDTO customer)
        {
            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                DriverLicenseNumber = customer.DriverLicenseNumber,
                CustomerProfileId = customer.CustomerProfileId
            };
            _unitOfWork.Customer.Add(newCustomer);
            _unitOfWork.Save();
            return Created();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer customer)
        {
            var customerToUpdate = _unitOfWork.Customer.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Email = customer.Email;
            customerToUpdate.PhoneNumber = customer.PhoneNumber;
            customerToUpdate.DriverLicenseNumber = customer.DriverLicenseNumber;
            customerToUpdate.CustomerProfileId = customer.CustomerProfileId;
            _unitOfWork.Customer.Update(customerToUpdate);
            _unitOfWork.Save();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _unitOfWork.Customer.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            _unitOfWork.Customer.Delete(customer);
            return NoContent();
        }
        [HttpGet("purchase-history/{id}")]
        public IActionResult GetCustomerPurchaseHistory(int id)
        {
            var history = _unitOfWork.Customer.GetCustomerPurchaseHistory(id).Select(s => new
            {
                Id = s.Id,
                SalesPrice = s.SalePrice,
                SaleDate = s.SalesDate
            });

            return Ok(history);
        }
    }
}
