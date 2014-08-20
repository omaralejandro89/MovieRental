using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models;

namespace MovieRental3.Models
{
    public class AllMoviesView
    {
        public List<MovieViewModel> MoviesList { get; set; }
    }

    public class MovieViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
    }
}