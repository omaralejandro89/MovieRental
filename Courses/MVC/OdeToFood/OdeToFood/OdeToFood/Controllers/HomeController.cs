using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls.Expressions;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb(); // Instatiate OdeToFoodDb

        public ActionResult Index(string searchTerm = null)
        {
            //var model =
            //    from r in _db.Restaurants
            //    //orderby r.RestaurantReviews.Count() descending 
            //    orderby r.RestaurantReviews.Average(restaurantReview => restaurantReview.Rating) descending
            //    select new RestaurantListViewModel
            //    {
            //        Id = r.Id,
            //        Name = r.Name,
            //        City = r.City,
            //        Country = r.Country,
            //        CountOfReviews = r.RestaurantReviews.Count()
            //    };

            var model =
                _db.Restaurants
                    .OrderByDescending(r => r.RestaurantReviews.Average(review => review.Rating))
                    .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                    .Take(10)
                    .Select(r => new RestaurantListViewModel()
                            {
                                Id = r.Id,
                                Name = r.Name,
                                City = r.City,
                                Country = r.Country,
                                CountOfReviews = r.RestaurantReviews.Count()
                            });


            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Omar";
            model.Location = "Oslo,Norway";

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
