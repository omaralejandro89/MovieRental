using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Core;
using MovieRental.Core.Models;
using MovieRental.Core.Repositories;
using MovieRental.ModelsView;
using MovieRental.Repositories.EntityFramework;

namespace MovieRental.Controllers
{
    public class HomeController : Controller
    {
        readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public ActionResult Index()
        {
            var customers = _customerRepository.GetAllCustomers();

            var allCustomerView = new AllCustomersView { CustomerList = new List<CustomerViewModel>()};

            foreach (var customer in customers)
            {
                var customerViewModel = new CustomerViewModel()
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                allCustomerView.CustomerList.Add(customerViewModel);
            }

            return View(allCustomerView);

        }

        public ActionResult Edit(int id)
        {
            var customer = _customerRepository.GetByIdCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.Update(customer);
                _customerRepository.Save(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Delete(int id)
        {
            Customer customer = _customerRepository.GetByIdCustomer(id);
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleActionResult(int id)
        {
            Customer customer = _customerRepository.GetByIdCustomer(id);
            _customerRepository.Delete(id);
            _customerRepository.Save(customer);
            return RedirectToAction("Index");
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
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}
