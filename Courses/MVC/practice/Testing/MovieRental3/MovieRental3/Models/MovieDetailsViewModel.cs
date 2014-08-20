using System.Collections.Generic;

namespace MovieRental3.Models
{
    public class MovieDetailsViewModel
    {
        public MovieDetailsMovieViewModel Movie { get; set; }
        public List<MovieDetaulsCustomerViewModel> Customers { get; set; }
    }

    public class MovieDetailsMovieViewModel
    {
        public int YearOfRelease { get; set; }
        public string Title { get; set; }
    }

    public class MovieDetaulsCustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerId { get; set; }

    }
}