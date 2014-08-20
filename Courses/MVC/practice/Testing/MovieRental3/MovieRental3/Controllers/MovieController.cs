using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Models.Repositories;
using MovieRental3.Models;

namespace MovieRental3.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMovieAlquiladaRepository _movieAlquilada;
        private readonly ICustomerRepository _customerRepository;

        public MovieController(IMovieRepository movieRepository, IMovieAlquiladaRepository movieAlquilada, ICustomerRepository customerRepository)
        {
            _movieRepository = movieRepository;
            _movieAlquilada = movieAlquilada;
            _customerRepository = customerRepository;
        }

        public ActionResult Index()
        {
            List<Movie> movies = _movieRepository.GetAllMovies();

            var allMoviesView = new AllMoviesView {MoviesList = new List<MovieViewModel>()};

            foreach (var movie in movies)
            {
                var movieViewModel = new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    Title = movie.Title,
                    YearOfRelease = movie.YearOfRelease
                };
                allMoviesView.MoviesList.Add(movieViewModel);
            }

            return View(allMoviesView);
        }


        public ActionResult Edit(int id)
        {
            var movie = _movieRepository.GetMovieByIdMovie(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            MovieDetailsViewModel movieDetailsViewModel = new MovieDetailsViewModel();

            Movie movie = _movieRepository.GetMovieByIdMovie(id);
            movieDetailsViewModel.Movie = new MovieDetailsMovieViewModel
            {
                Title = movie.Title,
                YearOfRelease = movie.YearOfRelease
            };

            var customers = _customerRepository.GetCustomerByMovie(id);
            movieDetailsViewModel.Customers = new List<MovieDetaulsCustomerViewModel>();

            foreach (var customerAlquila in customers)
            {
                Customer customer = _customerRepository.GetCustomerById(id);
                MovieDetaulsCustomerViewModel movieDetaulsCustomerViewModel = new MovieDetaulsCustomerViewModel
                {
                    CustomerId = customerAlquila.CustomerId,
                    FirstName = customerAlquila.FirstName,
                    LastName = customerAlquila.LastName
                };
                movieDetailsViewModel.Customers.Add(movieDetaulsCustomerViewModel);
            }

            return View(movieDetailsViewModel);






            //MovieDetailsViewModel movieDetailsView = new MovieDetailsViewModel();

            //Movie movie = _movieRepository.GetMovieByIdMovie(id);
            ////MovieDetailsMovieViewModel movieDetailsMovieViewModel = new MovieDetailsMovieViewModel
            //movieDetailsView.Movie = new MovieDetailsMovieViewModel
            //{
            //    Title = movie.Title,
            //    YearOfRelease = movie.YearOfRelease
            //};

            //var customerAlquila = _customerRepository.GetCustomerByMovie(id);

            //movieDetailsView.Customers = new List<MovieDetaulsCustomerViewModel>();

            //foreach (var customer in customerAlquila)
            //{
            //    var customerA = _customerRepository.GetCustomerById(customer.CustomerId);
            //    MovieDetaulsCustomerViewModel movieDetaulsCustomerViewModel = new MovieDetaulsCustomerViewModel
            //    {

            //        FirstName = customer.FirstName,
            //        LastName = customer.LastName
            //    };
            //    movieDetailsView.Customers.Add(movieDetaulsCustomerViewModel);
            //}

            //return View(movieDetailsView);
















            //Customer customer = _customerRepository.GetCustomerById(id);
            //MovieDetaulsCustomerViewModel movieDetaulsCustomerViewModel = new MovieDetaulsCustomerViewModel
            //{
            //    FirstName = customer.FirstName,
            //    LastName = customer.LastName
            //};


            //return View(movieDetailsMovieViewModel);





            //Movie movie = _movieRepository.GetMovieByIdMovie(id);
            //return View(movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = _movieRepository.GetMovieByIdMovie(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //Movie movie = _movieRepository.GetMovieByIdMovie(id);
            //_movieRepository.Delete(id);
            _movieRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Insert(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
