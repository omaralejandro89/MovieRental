using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental1.Repositories;

namespace MovieRental1.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieRepository _movieRepository = new MovieRepository();

        public ActionResult Index()
        {
            var movie = _movieRepository.GetMovieById(2);
            return View(movie);
        }

    }
}
