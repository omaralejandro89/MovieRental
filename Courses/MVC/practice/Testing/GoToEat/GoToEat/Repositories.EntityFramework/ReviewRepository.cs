using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using GoToEat.Core;
using GoToEat.Core.Models;
using GoToEat.Core.Repositories;

namespace GoToEat.Repositories.EntityFramework
{
    public class ReviewRepository: IReviewRepository
    {
        public Review GetReviewById(int reviewId)
        {
            using (var db = new GotoEatDb())
            {
                var review = db.Reviews.FirstOrDefault(c => c.ReviewId == reviewId);
                return review;
            }
        }

        public List<Review> GetAllReviews()
        {
            using (var db = new GotoEatDb())
            {
                return db.Reviews.ToList();
            }
        }

        public void InsertReview(Review review)
        {
            using (var db = new GotoEatDb())
            {
                db.Reviews.Add(review);
                db.SaveChanges();
            }
        }

        public void DeleteReview(int reviewId)
        {
            using (var db = new GotoEatDb())
            {
                var review = db.Reviews.Find(reviewId);
                db.Entry(review).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void UpdateReview(Review review)
        {
            using (var db = new GotoEatDb())
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Review> GetReviewByRestaurant(int restaurantId)
        {
            using (var db = new GotoEatDb())
            {
                var reviewsByRestaurant = db.Reviews.Where(x => x.RestaurantId == restaurantId).ToList();
                return reviewsByRestaurant;
            }
        }

        public Review GetSingleReviewByRestaurantId(int restaurantId)
        {
            using (var db = new GotoEatDb())
            {
                var review = db.Reviews.FirstOrDefault(w => w.RestaurantId == restaurantId);
                return review;
            }
        }
    }
}