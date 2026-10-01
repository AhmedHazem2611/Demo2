using System.ComponentModel.DataAnnotations;

namespace QuizTwo.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
