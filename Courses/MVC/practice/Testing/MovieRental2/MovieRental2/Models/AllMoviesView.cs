using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental2.Models
{
    public class AllMoviesView
    {
        public List<MovieList> MovieList { get; set; }
    }

    public class MovieList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
    }
}