using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTwo.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
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
        public Customer Customer { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
