using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTwo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
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
        public List<Sale> Sales { get; set; } = new List<Sale>();
        [ForeignKey(nameof(CustomerProfileId))]
        [Required]
        public int CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
    }
}
