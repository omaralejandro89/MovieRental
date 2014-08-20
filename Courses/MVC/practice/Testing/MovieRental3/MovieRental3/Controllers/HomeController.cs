using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Models.Models;
using Models.Repositories;
using MovieRental3.Models;
using MovieRental3.Repositories.EntityFramework;

namespace MovieRental3.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICustomerRepository _customerRepository;

        //public HomeController(ICustomerRepository customerRepository)
        //{
        //    _customerRepository = customerRepository;
        //}

        private readonly ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }



        public ActionResult Index()
        {
            List<Customer> customers = _customerRepository.GetAll();

            var homeViewModel = new HomeViewModel {CustomersList = new List<CustomerViewModel>()};

            foreach (Customer customer in customers)
            {
                var customerViewModel = new CustomerViewModel
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                homeViewModel.CustomersList.Add(customerViewModel);
            }
            return View(homeViewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.Update(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }


        public ActionResult Delete(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            _customerRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}

