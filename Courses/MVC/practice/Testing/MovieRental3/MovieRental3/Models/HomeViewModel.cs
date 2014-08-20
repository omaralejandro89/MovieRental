using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models;

namespace MovieRental3.Models
{
    public class HomeViewModel
    {
        public List<CustomerViewModel> CustomersList { get; set; }
    }

    public class CustomerViewModel  
    {
        public  int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}