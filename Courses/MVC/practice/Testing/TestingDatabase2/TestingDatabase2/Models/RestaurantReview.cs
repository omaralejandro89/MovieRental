using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingDatabase2.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }
    }
}