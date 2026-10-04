using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTwo.DTOs;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesController(IUnitOfWork employeeRepo)
        {
            _unitOfWork = employeeRepo;
        }
        [HttpGet("{id}/sales-stat")]
        public IActionResult GetEmployeeSalesStat(int id)
        {
            var employee = _unitOfWork.Employee.GetEmployeeSalesStat(id).Select(s => new
            {
                Id = s.Id,
                SalesPrice = s.SalePrice,
                SaleDate = s.SalesDate
            });
            return Ok(employee);
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _unitOfWork.Employee.GetAll();
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                employeeDTOs.Add(new EmployeeDTO
                {
                    Id = employee.Id,
                    FullName = employee.FullName,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Position = employee.Position,
                    HireDate = employee.HireDate
                });
            }
            return Ok(employeeDTOs);
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int Id)
        {
            var employee = _unitOfWork.Employee.GetById(Id);
            if (employee == null)
            {
                return NotFound();
            }
            _unitOfWork.Employee.Delete(employee);
            _unitOfWork.Save();
            return NoContent();
        }
        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                FullName = employeeDTO.FullName,
                Email = employeeDTO.Email,
                PhoneNumber = employeeDTO.PhoneNumber,
                Position = employeeDTO.Position,
                HireDate = employeeDTO.HireDate
            };
            _unitOfWork.Employee.Add(employee);
            _unitOfWork.Save();
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateEmployee(int Id, EmployeeDTO employeeDTO)
        {
            var employee = _unitOfWork.Employee.GetById(Id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.FullName = employeeDTO.FullName;
            employee.Email = employeeDTO.Email;
            employee.PhoneNumber = employeeDTO.PhoneNumber;
            employee.Position = employeeDTO.Position;
            employee.HireDate = employeeDTO.HireDate;
            _unitOfWork.Employee.Update(employee);
            _unitOfWork.Save();
            return NoContent();
        }
    }
}
