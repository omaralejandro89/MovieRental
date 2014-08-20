using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        //
        // GET: /Reviews/

        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();


            //var model =
            //    from r in _db.RestaurantReviews.ToList()
            //    orderby r.Rating
            //    select r;

            //return View(model);
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview restaurantReview)
        {
            if (ModelState.IsValid)
            {
                _db.RestaurantReviews.Add(restaurantReview);
                _db.SaveChanges();
                return RedirectToAction("Index", new {id = restaurantReview.RestaurantId});
            }
            return View(restaurantReview);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.RestaurantReviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReview restaurantReview)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(restaurantReview).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new {id = restaurantReview.RestaurantId});
            }
            return View(restaurantReview);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
