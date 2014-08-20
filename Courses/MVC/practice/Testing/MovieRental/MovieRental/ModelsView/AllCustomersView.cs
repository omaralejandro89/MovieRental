using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.ModelsView
{
    public class AllCustomersView
    {
        public List<CustomerViewModel> CustomerList { get; set; }
    }

    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}