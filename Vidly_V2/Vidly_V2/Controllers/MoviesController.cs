using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly_V2.Models;
using Vidly_V2.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController:Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult New()
        {
            var genreTypes = _context.GenreTypes.ToList();
            var viewModel = new MovieFormViewModel
            {
                GenreTypes = genreTypes
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                movie.AddDate = System.DateTime.Now;
                _context.Movies.Add(movie);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.GenreType).ToList();

            return View(movies);
        }

        public ActionResult Details(byte id)
        {
            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);
            if(movie == null)
                return HttpNotFound();
            return View(movie);

        }

    }
}