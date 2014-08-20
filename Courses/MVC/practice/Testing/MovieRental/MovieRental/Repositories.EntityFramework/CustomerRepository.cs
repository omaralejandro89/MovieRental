using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MovieRental.Core;
using MovieRental.Core.Models;
using MovieRental.Core.Repositories;

namespace MovieRental.Repositories.EntityFramework
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly MyDbContext _db = new MyDbContext();

        public List<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public Customer GetByIdCustomer(int id)
        {
            var customer = _db.Customers.FirstOrDefault(b => b.CustomerId == id);
            return customer;
        }

        public void Update(Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
        }

        public void Save(Customer customer)
        {
            _db.SaveChanges();
        }

        public void Insert(Customer customer)
        {
            _db.Customers.Add(customer);
        }

        public void Delete(int customerId)
        {
            var customer = _db.Customers.Find(customerId);
            _db.Customers.Remove(customer);
        }
    }
}