using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using Models.Models;
using Models.Repositories;

namespace MovieRental3.Repositories.EntityFramework
{
    public class CustomerRepository : ICustomerRepository
    {
        //private MovieRental3Db _db = new MovieRental3Db();

        public void RegisterUser()
        {
            // 1. validation

            // 2. save - SQL Server

            // 3. send email - gmail

            // 4. log - 
        }

        public Customer GetCustomerById(int id)
        {
            using (var db = new MovieRental3Db())
            {
                Customer customer = db.Customers.FirstOrDefault(b => b.CustomerId == id);
                return customer;
            }
        }

        public List<Customer> GetAll()
        {
            using (var db =new MovieRental3Db())
            {
                return db.Customers.ToList();
            }
        }

        public void Insert(Customer customer)
        {
            using (var db = new MovieRental3Db())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (var db = new MovieRental3Db())
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int customerId)
        {
            using (var db = new MovieRental3Db())
            {
                var customer = new Customer {CustomerId = customerId};
                db.Entry(customer).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Customer> GetCustomerByMovie(int movieId)
        {
            using (var db = new MovieRental3Db())
            {
                var customers = new List<Customer>();
                var rentals = db.MovieAlquiladas.Where(x => x.MovieId == movieId).ToList();
                foreach (var rental in rentals)
                {
                    var customer = db.Customers.FirstOrDefault(x => x.CustomerId == rental.CustomerId);
                    if (customer != null)
                    {
                        customers.Add(customer);
                    }
                }

                return customers;
            }
        }
    }
}