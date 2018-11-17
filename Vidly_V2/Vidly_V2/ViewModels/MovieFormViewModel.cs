using System.Collections.Generic;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        public Movie movie { get; set; }

        public string Title
        {
            get
            {
                if(movie != null && movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}