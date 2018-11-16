using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly_V2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddDate { get; set; }
        [Required]
        public byte Stock { get; set; }
        public GenreType GenreType { get; set; }
        [Required]
        public byte? GenreTypeId { get; set; }
    }
}