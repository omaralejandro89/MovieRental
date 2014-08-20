using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.ModelsView
{
    public class AllMoviesView
    {
        public List<MovieViewModel> MovieList { get; set; }
    }

    public class MovieViewModel
    {
        public int MovieId { get; set; }
        public int YearOfRelease { get; set; }
        public string Title { get; set; }
    }
}