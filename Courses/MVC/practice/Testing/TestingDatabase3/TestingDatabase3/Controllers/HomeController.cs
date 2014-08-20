using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingDatabase3.Models;

namespace TestingDatabase3.Controllers
{
    public class HomeController : Controller
    {
        OmarDb _db = new OmarDb();

        public ActionResult Index( string search = null)
        {
            //var model = _db.Restaurants.ToList();

            //return View(model);

            //var model =
            //    from r in _db.Restaurants
            //    orderby r.Name
            //    select r;

            var model =
                _db.Restaurants
                    .OrderByDescending(r => r.RestaurantReviews.Average(restaurantReview => restaurantReview.Rating))
                    .Where(r => search == null || r.Name.StartsWith(search))
                    .Select(r => new RestaurantListViewModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        City = r.City,
                        NumberOfReviews = r.RestaurantReviews.Count()
                    });
                    

            return View(model);

        }

        public ActionResult About()
        {
            var model = _db.RestaurantReviews.ToList();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
