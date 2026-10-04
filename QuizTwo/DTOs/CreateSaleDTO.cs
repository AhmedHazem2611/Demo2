using QuizTwo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTwo.DTOs
{
    public class UpdateSaleDTO
    {
        [Required]
        public DateTime SalesDate { get; set; }
        [Required]
        [Range(1, double.MaxValue)]
        public decimal SalePrice { get; set; }
        [Required]
        [MaxLength(30)]
        public string PaymentMethod { get; set; }
        [MaxLength(300)]
        public string? Notes { get; set; }
        [Required]
        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [Required]
        public int EmployeeId { get; set; }
        public int VehicleId { get; set; }
    }
}
