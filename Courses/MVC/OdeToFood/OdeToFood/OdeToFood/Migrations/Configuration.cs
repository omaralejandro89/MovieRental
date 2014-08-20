using System.Collections.Generic;
using System.Collections.ObjectModel;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        //protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        //{
        //    context.Restaurants.AddOrUpdate(r => r.Name,
        //        new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA", },
        //        new Restaurant
        //        {
        //            Name = "Smaka",
        //            City = "Gothenburg",
        //            Country = "Sweden",
        //            RestaurantReviews = new List<RestaurantReview>
        //            {
        //                new RestaurantReview { Rating = 9, Body = "Great food!"}
        //            }
        //        });
        //}
    }
}
