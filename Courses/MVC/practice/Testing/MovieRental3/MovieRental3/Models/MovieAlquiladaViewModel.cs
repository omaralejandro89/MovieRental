using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental3.Models
{
    public class MovieAlquiladaViewModel
    {
        public RentedDetailsCustomerViewModel Customer { get; set; }
        public List<RentedDetailsMovieViewModel> Movies { get; set; }

        public bool HasMovies
        {
            get { return Movies != null && Movies.Count > 0; }
        }
    }

    public class RentedDetailsMovieViewModel
    {
        public int MovieRentalId { get; set; }
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }
    }

    public class RentedDetailsCustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


}


































