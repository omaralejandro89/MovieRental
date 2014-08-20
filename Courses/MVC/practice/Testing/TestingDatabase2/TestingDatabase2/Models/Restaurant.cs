using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingDatabase2.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<RestaurantReview> RestaurantReviews { get; set; }
    }
}