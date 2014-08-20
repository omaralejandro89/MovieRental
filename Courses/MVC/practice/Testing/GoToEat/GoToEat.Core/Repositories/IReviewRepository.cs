using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoToEat.Core.Models;

namespace GoToEat.Core.Repositories
{
    public interface IReviewRepository
    {
        Review GetReviewById(int reviewId);
        List<Review> GetAllReviews();
        void InsertReview(Review review);
        void DeleteReview(int reviewId);
        void UpdateReview(Review review);
        List<Review> GetReviewByRestaurant(int restaurantId);
        Review GetSingleReviewByRestaurantId(int restaurantId);
    }
}
