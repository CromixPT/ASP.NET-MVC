using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController:Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek!" },
                new Movie { Name = "Wall-e"}
            };

            return View(movies);

        }



        //public ActionResult Edit(int id)  
        //{
        //    return Content("id=" + id);
        //}
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)")]

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}