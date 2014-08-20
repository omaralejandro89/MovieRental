using System;
using System.Collections.Generic;

namespace MovieRental2.Models
{
    public class RentalDetailsViewModel
    {
        public RentedDetailsCustomerViewModel Customer { get; set; }
        public List<RentedDetailsMovieViewModel> Movies { get; set; }
        public bool HasMovies { get { return Movies != null && Movies.Count > 0; }}
    }

    public class RentedDetailsCustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class RentedDetailsMovieViewModel
    {
        public int MovieRentalId { get; set; }
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }

        public DateTime DateTaken { get; set; }
        public DateTime? DateReturned { get; set; }
        public bool IsReturened { get { return DateReturned.HasValue; }}
    }
}