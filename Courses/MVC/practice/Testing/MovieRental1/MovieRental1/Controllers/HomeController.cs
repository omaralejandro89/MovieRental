using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental1.Core.Models;
using MovieRental1.Core.Repositories;
using MovieRental1.Repositories;
using MovieRental1.ViewModels;

namespace MovieRental1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public ActionResult Index()
        {
            var model = _customerRepository.GetById(0);
            return View(model);
        }

        public ActionResult AllCustomer()
        {
            var customers = _customerRepository.getAll();

            var customersViewModel = new CustomersViewModel {Customers = new List<CustomerViewModel>()};

            foreach (var customer in customers)
            {
                var customerViewModel = new CustomerViewModel
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                };

                customersViewModel.Customers.Add(customerViewModel);
            }
            return View(customersViewModel);
        }
    }
}
