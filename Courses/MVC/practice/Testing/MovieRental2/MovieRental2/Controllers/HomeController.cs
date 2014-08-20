using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;
using MovieRental2.Models;

namespace MovieRental2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IMovieRentalRepository _movieRentalRepository;

        public HomeController(ICustomerRepository customerRepository, IMovieRepository movieRepository, IMovieRentalRepository movieRentalRepository)
        {
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _movieRentalRepository = movieRentalRepository;
        }

        public ActionResult Index()
        {
            Customer customer = _customerRepository.GetByIdCustomer(2);
            return View(customer);
        }

        public ActionResult AllCustomers()
        {
            List<Customer> customers = _customerRepository.GetAllCustomers();

            var allCustomersView = new AllCustomersView {CustomersList = new List<CustomerViewModel>()};

            foreach (Customer customer in customers)
            {
                var customerViewModel = new CustomerViewModel
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                allCustomersView.CustomersList.Add(customerViewModel);
            }

            return View(allCustomersView);
        }

        public ActionResult Edit(int id)
        {
            Customer customer = _customerRepository.GetByIdCustomer(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.Update(customer);
                _customerRepository.Save(customer);
                return RedirectToAction("AllCustomers");
            }
            return View(customer);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Customer());
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.Insert(customer);
                _customerRepository.Save(customer);
                return RedirectToAction("AllCustomers");
            }
            return View(customer);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Customer customer = _customerRepository.GetByIdCustomer(id);
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteCorfimed(int id)
        {
            Customer customer = _customerRepository.GetByIdCustomer(id);
            _customerRepository.Delete(id);
            _customerRepository.Save(customer);
            return RedirectToAction("AllCustomers");
        }

        public ActionResult MoreInfo(int id)
        {
            var viewModel = new RentalDetailsViewModel();

            var customer = _customerRepository.GetByIdCustomer(id);
            if (customer == null)
            {
                return new HttpNotFoundResult();
            }



            viewModel.Customer = new RentedDetailsCustomerViewModel
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName
            };

            var rentals = _movieRentalRepository.GetRentedMoviesByCustomer(id);
            if (rentals != null)
            {
                viewModel.Movies = new List<RentedDetailsMovieViewModel>(rentals.Count);

                foreach (var rental in rentals)
                {
                    var movie = _movieRepository.GetByIdMovie(rental.MovieId);
                    var movieViewModel = new RentedDetailsMovieViewModel
                    {
                        DateTaken = rental.DateTaken,
                        DateReturned = rental.DateReturned,
                        MovieRentalId = rental.MovieRentalId,
                        MovieName = movie.Title,
                        YearOfRelease = movie.YearOfRelease
                    };

                    viewModel.Movies.Add(movieViewModel);
                }
            }

            return View(viewModel);
        }
    }
}