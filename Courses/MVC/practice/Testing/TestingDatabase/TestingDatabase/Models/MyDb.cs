using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingDatabase.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("TestingDatabase")
        {
            
        }
 
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }

    }
}