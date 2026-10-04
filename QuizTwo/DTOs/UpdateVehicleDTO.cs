using QuizTwo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTwo.DTOs
{
    public class UpdateVehicleDTO
    {
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
