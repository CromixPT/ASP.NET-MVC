using System.ComponentModel.DataAnnotations;

namespace Vidly_V2.Models
{
    public class GenreType
    {
        [Key]
        [Required]
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}