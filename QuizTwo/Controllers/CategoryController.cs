using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTwo.DTOs;
using QuizTwo.Models;
using QuizTwo.Repos.Implementation;
using QuizTwo.Repos.Interface;
using System.Numerics;

namespace QuizTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _unitOfWork.Category.GetAll();
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoryDTOs.Add(new CategoryDTO
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                });
            }
            return Ok(categoryDTOs);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            var category = _unitOfWork.Category.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Delete(category);
            _unitOfWork.Save();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description
            };
            _unitOfWork.Category.Add(category);
            _unitOfWork.Save();
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryDTO categoryDTO)
        {
            var category = _unitOfWork.Category.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            category.Name = categoryDTO.Name;
            category.Description = categoryDTO.Description;
            _unitOfWork.Category.Update(category);
            _unitOfWork.Save();
            return NoContent();
        }
    }
}
