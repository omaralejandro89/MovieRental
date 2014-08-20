using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental1.Core.Models;
using MovieRental1.Core.Repositories;

namespace MovieRental1.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Core.Models.Customer GetById(int id)
        {
            var db = new MovieRental1Db();
            Customer customer = db.Customers.FirstOrDefault(b => b.CustomerId == id);

            return customer;


        }

        public List<Core.Models.Customer> getAll()
        {
            var db = new MovieRental1Db();

            return db.Customers.OrderByDescending(r => r.LastName).ToList();
        }

        public void Update(Core.Models.Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Save(Core.Models.Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}