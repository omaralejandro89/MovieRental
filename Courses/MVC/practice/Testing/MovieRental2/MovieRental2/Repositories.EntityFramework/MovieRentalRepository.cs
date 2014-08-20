using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;

namespace MovieRental2.Repositories.EntityFramework
{
    public class MovieRentalRepository : IMovieRentalRepository
    {
        public void Save(MovieRental movieRental)
        {
            throw new NotImplementedException();
        }

        public List<MovieRental> GetRentedMoviesByCustomer(int customerId)
        {
            using (var db = new MovieRental2Db())
            {
                var rentals = db.MovieRentals.Where(x => x.CustomerId == customerId).ToList();
                return rentals;
            }
        }
    }
}