using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Core.Models;
using MovieRental.ModelsView;
using MovieRental.Repositories.EntityFramework;

namespace MovieRental.Controllers
{
    public class MovieController : Controller
    {
        readonly MovieRepository _movieRepository = new MovieRepository();

        public ActionResult Index()
        {
            var movies = _movieRepository.GetAllMovies();

            var allMoviesView = new AllMoviesView {MovieList = new List<MovieViewModel>()};

            
            foreach (var movie in movies)
            {
                var movieViewModel = new MovieViewModel()
                {
                    MovieId = movie.MovieId,
                    Title = movie.Title,
                    YearOfRelease = movie.YearOfRelease
                };
                allMoviesView.MovieList.Add(movieViewModel);
            }
            return View(allMoviesView);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Insert(movie);
                _movieRepository.Save(movie);
                return RedirectToAction("Index");
            }
            return View(movie);

        }
    }
}
