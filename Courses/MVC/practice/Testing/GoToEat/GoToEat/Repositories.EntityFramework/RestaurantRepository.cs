using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using GoToEat.Core;
using GoToEat.Core.Repositories;
using Microsoft.Ajax.Utilities;

namespace GoToEat.Repositories.EntityFramework
{
    public class RestaurantRepository : IRestaurantRepository
    {
        

        public Restaurant GetRestaurantById(int restaurantId)
        {
            using (var db = new GotoEatDb())
            {
                var restaurant = db.Restaurants.FirstOrDefault(x => x.RestaurantId == restaurantId);
                return restaurant;
            }
        }

        public List<Restaurant> GetAllRestaurants()
        {
            using (var db = new GotoEatDb())
            {
                return db.Restaurants.ToList();
            }
        }

        public void Insert(Restaurant restaurant)
        {
            using (var db = new GotoEatDb())
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
            }
        }

        public void Update(Restaurant restaurant)
        {
            using (var db = new GotoEatDb())
            {
                db.Entry(restaurant).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int restaurantId)
        {
            using (var db = new GotoEatDb())
            {
                var restaurant = db.Restaurants.Find(restaurantId);
                db.Entry(restaurant).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        //public Restaurant GetRestaurantByReviewId(int reviewId)
        //{
        //    using (var db = new GotoEatDb())
        //    {
        //        var restaurant = db.Restaurants.FirstOrDefault(x => x.ReviewId == reviewId);
        //        return restaurant;
        //    }
        //}
    }
}