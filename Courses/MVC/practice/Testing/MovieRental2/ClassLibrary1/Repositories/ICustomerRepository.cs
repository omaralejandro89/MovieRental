using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;

namespace ClassLibrary1.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetByIdCustomer(int id);
        List<Customer> GetAllCustomers();
        void Update(Customer customer);
        void Save(Customer customer);
        void Insert(Customer customer);
        void Delete(int CustomerID);
    }
}
