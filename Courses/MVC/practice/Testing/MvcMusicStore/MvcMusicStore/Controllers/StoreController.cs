using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return Content(message);
        }

        public ActionResult Details(int id)
        {
            string message = "Store.Details, ID = " + id; 
            return Content(message);
        }

    }
}
