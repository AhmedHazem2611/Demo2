using QuizTwo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTwo.DTOs
{
    public class CreateCustomerDTO
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(20)]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string DriverLicenseNumber { get; set; }
        [ForeignKey(nameof(CustomerProfileId))]
        [Required]
        public int CustomerProfileId { get; set; }

    }
}
