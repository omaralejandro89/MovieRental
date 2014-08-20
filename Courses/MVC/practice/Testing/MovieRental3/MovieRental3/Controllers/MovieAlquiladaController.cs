using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Models.Models;
using Models.Repositories;
using MovieRental3.Models;
using MovieRental3.Repositories.EntityFramework;

namespace MovieRental3.Controllers
{
    public class MovieAlquiladaController : Controller
    {
        private readonly IMovieAlquiladaRepository _movieAlquiladaRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly ICustomerRepository _customerRepository;

        public MovieAlquiladaController(IMovieAlquiladaRepository movieAlquiladaRepository, ICustomerRepository customerRepository, IMovieRepository movieRepository)
        {
            _movieAlquiladaRepository = movieAlquiladaRepository;
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
        }

        public ActionResult Index(int id)
        {

            var movieAlquiladaViewModel = new MovieAlquiladaViewModel();

            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return new HttpNotFoundResult();
            }

            movieAlquiladaViewModel.Customer = new RentedDetailsCustomerViewModel
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName
            };

            var rentals = _movieAlquiladaRepository.GetMoviesAlquiladasByCustomer(id);
            if (rentals != null)
            {
                movieAlquiladaViewModel.Movies = new List<RentedDetailsMovieViewModel>();

                foreach (var movieAlquilada in rentals)
                {
                    var movie = _movieRepository.GetMovieByIdMovie(movieAlquilada.MovieId);
                    var rentedDetailsMovieViewModel = new RentedDetailsMovieViewModel
                    {
                        MovieName = movie.Title,
                        MovieRentalId = movieAlquilada.MovieAlquiladaId,
                        YearOfRelease = movie.YearOfRelease
                    };
                    movieAlquiladaViewModel.Movies.Add(rentedDetailsMovieViewModel);

                }
            }

            return View(movieAlquiladaViewModel);
        }

    }
}
