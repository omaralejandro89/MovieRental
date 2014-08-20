using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;
using Microsoft.Ajax.Utilities;

namespace MovieRental2.Repositories.EntityFramework
{
    public class CustomerRepository: ICustomerRepository
    {
        readonly MovieRental2Db _db = new MovieRental2Db();

        public Customer GetByIdCustomer(int id)
        {
            Customer customer = _db.Customers.FirstOrDefault(b => b.CustomerId == id);
            return customer;
        }

        public List<ClassLibrary1.Models.Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public void Update(ClassLibrary1.Models.Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
        }

        public void Save(ClassLibrary1.Models.Customer customer)
        //public void Save()
        {
            _db.SaveChanges();
        }

        public void Insert(Customer customer)
        {
            _db.Customers.Add(customer);
        }

        public void Delete(int CustomerID)
        {
            Customer customer = _db.Customers.Find(CustomerID);
            _db.Customers.Remove(customer);
        }



        //public List<RentedMovie> GetRentedMovies()
        //{
           
        //}
    }
}