using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingDatabase3.Models
{
    public class OmarDb : DbContext
    {
        public OmarDb(): base("TestingOmar")
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
    }
}