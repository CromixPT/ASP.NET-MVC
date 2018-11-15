using System.Collections.Generic;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}