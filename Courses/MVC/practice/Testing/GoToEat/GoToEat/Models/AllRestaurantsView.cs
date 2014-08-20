using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoToEat.Core;

namespace GoToEat.Models
{
    public class AllRestaurantsView
    {
        public List<RestaurantViewModel> Restaurants { get; set; } 
    }

    public class RestaurantViewModel   
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ReviewId { get; set; }
    }
}