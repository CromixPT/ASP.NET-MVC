using System.Collections.Generic;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        public Movie Movie { get; set; }
    }
}