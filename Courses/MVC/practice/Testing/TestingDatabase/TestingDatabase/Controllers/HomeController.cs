using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingDatabase.Models;

namespace TestingDatabase.Controllers
{
    public class HomeController : Controller
    {
        MyDb _db = new MyDb();

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();
            //from r in _db.Restaurants
            //orderby r.Reviews.Count() descending 
            //select r;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
