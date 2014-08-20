using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoToEat.Models
{
    public class AllRestaurantReviewsView
    {
        public List<RestaurantReviewViewModel> RestaurantReviews { get; set; }
        public RestaurantDetailsViewModel RestaurantDetailsViewModel { get; set; }

        public bool HasReviews
        {
            get
            {
                return RestaurantReviews != null && RestaurantReviews.Count > 0;
            }
        }
    }

    public class RestaurantDetailsViewModel
    {
        public int ReviewId { get; set; }
        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        
    }

    public class RestaurantReviewViewModel
    {
        public int ReviewId { get; set; }
        public int RestaurantId { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
    }
}