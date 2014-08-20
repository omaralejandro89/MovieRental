using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingDatabase3.Models
{
    public class RestaurantListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int NumberOfReviews { get; set; }
    }
}