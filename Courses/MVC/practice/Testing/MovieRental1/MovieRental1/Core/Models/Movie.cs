using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental1.Core.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string YearOfRelease { get; set; }
    }
}