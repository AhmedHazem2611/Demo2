using QuizTwo.Models;
using System.ComponentModel.DataAnnotations;

namespace QuizTwo.DTOs
{
    public class EmployeeDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(20)]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
