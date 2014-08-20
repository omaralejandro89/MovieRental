using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoToEat.Models
{
    public class DeleteReviewView
    {
        public int ReviewId { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
    }
}