using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1.Models;

namespace MovieRental2.Models
{
    public class AllCustomersView
    {
        public List<CustomerViewModel> CustomersList { get; set; }
    }

    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}