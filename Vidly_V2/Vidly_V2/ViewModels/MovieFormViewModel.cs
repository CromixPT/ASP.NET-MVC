using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.ReleaseDate = movie.ReleaseDate;
            this.Stock = movie.Stock;
            this.GenreTypeId = movie.GenreTypeId;
        }

        public IEnumerable<GenreType> GenreTypes { get; set; }

        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Quantity in stock")]
        [Range(1, 20)]
        public byte? Stock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}