using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental1.Core.Models;

namespace MovieRental1.Core.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        List<Customer> getAll();
        void Update(Customer customer);
        void Save(Customer customer);
    }
}