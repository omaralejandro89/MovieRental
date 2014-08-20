using System.Collections.Generic;
using Models.Models;

namespace Models.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        List<Customer> GetAll();
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        List<Customer> GetCustomerByMovie(int movieId);
    }
}