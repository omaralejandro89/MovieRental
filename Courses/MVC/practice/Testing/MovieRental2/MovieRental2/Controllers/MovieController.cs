using System.Collections.Generic;
using System.Web.Mvc;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;
using MovieRental2.Models;

namespace MovieRental2.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public ActionResult Index()
        {
            Movie movie = _movieRepository.GetByIdMovie(1);
            return View(movie);
        }

        public ActionResult AllMovies()
        {
            List<Movie> movies = _movieRepository.GetAllMovies();

            var allMoviesView = new AllMoviesView {MovieList = new List<MovieList>()};

            foreach (Movie movie in movies)
            {
                var movieList = new MovieList
                {
                    Id = movie.MovieId,
                    Title = movie.Title,
                    YearOfRelease = movie.YearOfRelease
                };
                allMoviesView.MovieList.Add(movieList);
            }

            return View(allMoviesView);
        }
    }
}