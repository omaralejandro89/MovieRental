using System.Collections.Generic;
using MovieRental.Core.Models;

namespace MovieRental.Core.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetByIdCustomer(int id);
        List<Customer> GetAllCustomers();
        void Update(Customer customer);
        void Save(Customer customer);
        void Insert(Customer customer);
        void Delete(int customerId);
    }
}
