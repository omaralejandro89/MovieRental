using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using GoToEat.Core;
using GoToEat.Core.Models;
using GoToEat.Core.Repositories;
using GoToEat.Models;
using StructureMap.Query;

namespace GoToEat.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            _restaurantRepository = restaurantRepository;
            _reviewRepository = reviewRepository;
        }


        //
        // GET: /Review/

        public ActionResult Index()
        {
            var restaurants = _restaurantRepository.GetAllRestaurants();
            var reviews = _reviewRepository.GetAllReviews();

            AllReviewView allReviewView = new AllReviewView();

            allReviewView.AllReviewDetailViewModel = new List<AllReviewDetailViewModel>();
            foreach (var restaurant in restaurants)
            {
                AllReviewDetailViewModel allReviewDetailViewModel = new AllReviewDetailViewModel
                {
                    RestaurantName = restaurant.RestaurantName
                };
                allReviewView.AllReviewDetailViewModel.Add(allReviewDetailViewModel);
            }


            allReviewView.Reviews = new List<AllReviewViewModel>();
            foreach (var review in reviews)
            {
                var allReviewViewModel = new AllReviewViewModel
                {
                    RestaurantId = review.RestaurantId,
                    ReviewId = review.ReviewId,
                     
                    Body = review.Body,
                    Rating = review.Rating,
                    Reviewer = review.Reviewer
                };

                var restaurant = _restaurantRepository.GetRestaurantById(review.RestaurantId);
                if (restaurant != null)
                {
                    allReviewViewModel.RestaurantName = restaurant.RestaurantName;
                }

                allReviewView.Reviews.Add(allReviewViewModel);
            }
            return View(allReviewView);


        }


        public ActionResult ReviewsByRestaurant(int id)
        {
            //AllRestaurantReviewsView allRestaurantReviewsView = new AllRestaurantReviewsView {RestaurantReviews = new List<RestaurantReviewViewModel>()};

            AllRestaurantReviewsView allRestaurantReviewsView = new AllRestaurantReviewsView();

            var restaurant = _restaurantRepository.GetRestaurantById(id);
            //allRestaurantReviewsView.RestaurantDetailsViewModel = new RestaurantDetailsViewModel
            allRestaurantReviewsView.RestaurantDetailsViewModel = new RestaurantDetailsViewModel
            {
                RestaurantId = restaurant.RestaurantId,
                RestaurantName = restaurant.RestaurantName,             
            };



            var restaurantReviews = _reviewRepository.GetReviewByRestaurant(id);
            allRestaurantReviewsView.RestaurantReviews = new List<RestaurantReviewViewModel>();
            foreach (var restaurantReview in restaurantReviews)
            {
                RestaurantReviewViewModel restaurantReviewViewModel = new RestaurantReviewViewModel
                {
                    ReviewId = restaurantReview.ReviewId,
                    RestaurantId = restaurantReview.RestaurantId,
                    Reviewer = restaurantReview.Reviewer,
                    Rating = restaurantReview.Rating,
                    Body = restaurantReview.Body
                };
                allRestaurantReviewsView.RestaurantReviews.Add(restaurantReviewViewModel);
            }
            return View(allRestaurantReviewsView);
        }

        public ActionResult Edit(int id)
        {
            var review = _reviewRepository.GetReviewById(id);
            return View(review);
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewRepository.UpdateReview(review);
                return RedirectToAction("ReviewsByRestaurant", new {id = review.RestaurantId});
            }
            return View(review);
        }


        public ActionResult Create(int restaurantId)
        {
            var review = new Review {RestaurantId = restaurantId};
            return View(review);
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewRepository.InsertReview(review);
                return RedirectToAction("ReviewsByRestaurant", new { id = review.RestaurantId });
            }
            return View(review);
        }


        public ActionResult Delete(int id)
        {
            var review = _reviewRepository.GetReviewById(id);
            return View(review);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var review = _reviewRepository.GetReviewById(id);
                        _reviewRepository.DeleteReview(id);
                        return RedirectToAction("ReviewsByRestaurant", new { id = review.RestaurantId });
        }
    }
}
