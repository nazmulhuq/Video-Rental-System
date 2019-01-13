using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Movies
        public ActionResult Index()
        {
            //var viewModel = new IndexMovieViewModel()
            //{
            //    Movies = _context.Movies.Include(m=> m.Genre).ToList()
            //};
            //return View(viewModel);

            if (User.IsInRole(RoleName.CanManageMovies)
                | User.IsInRole(RoleName.CanManageAll))
                return View("List");

            return View("ReadOnlyList");

        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        //........movies/new (registers new movie)
        [Authorize(Roles = RoleName.CanManageMovies)]
        [Authorize(Roles = RoleName.CanManageAll)]
        public ActionResult New()
        {

            var viewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm",viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            //ModelState["movie.Id"].Errors.Clear();
            if(!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }
            if(movie.Id==0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.StockNumber = movie.StockNumber;
                movieInDb.GenreId = movie.GenreId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
         
        }


        //...........movies/edit/id
        [Authorize(Roles = RoleName.CanManageMovies)]
        [Authorize(Roles = RoleName.CanManageAll)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
    }
}