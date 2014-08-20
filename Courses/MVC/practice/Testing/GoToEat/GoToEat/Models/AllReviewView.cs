using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GoToEat.Core;
using GoToEat.Core.Models;

namespace GoToEat.Models
{
    public class AllReviewView
    {
        public List<AllReviewViewModel> Reviews { get; set; }
        public List<AllReviewDetailViewModel> AllReviewDetailViewModel { get; set; }
    }

    public class AllReviewDetailViewModel
    {
        public virtual string RestaurantName { get; set; }
    }

    public class AllReviewViewModel
    {
        public int ReviewId { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Reviewer { get; set; }
        [UIHint("Rating")]
        public int Rating { get; set; }
        public string Body { get; set; }
    }

}