using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental1.ViewModels
{
    public class CustomersViewModel
    {
        public List<CustomerViewModel> Customers { get; set; }
    }

    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}