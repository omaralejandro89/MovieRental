using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoToEat.Core;
using GoToEat.Core.Repositories;
using GoToEat.Models;

namespace GoToEat.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        //
        // GET: /Restaurant/

        public ActionResult Index()
        {
            var restaurants = _restaurantRepository.GetAllRestaurants();

            AllRestaurantsView allRestaurantsView = new AllRestaurantsView { Restaurants = new List<RestaurantViewModel>()};

            foreach (var restaurant in restaurants)
            {
                RestaurantViewModel restaurantViewModel = new RestaurantViewModel
                {
                    RestaurantId = restaurant.RestaurantId,
                    RestaurantName = restaurant.RestaurantName,
                    City = restaurant.City,
                    Country = restaurant.Country                    
                };
                allRestaurantsView.Restaurants.Add(restaurantViewModel);
            }
            return View(allRestaurantsView);
        }

        public ActionResult Create()
        {
            var restaurant = new Restaurant();
            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantRepository.Insert(restaurant);
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }


        public ActionResult Edit(int id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantRepository.Update(restaurant);
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        public ActionResult Details(int id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return View(restaurant);
        }

        public ActionResult Delete(int id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return View(restaurant);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
                _restaurantRepository.Delete(id);
                return RedirectToAction("Index");
        }
    }
}
