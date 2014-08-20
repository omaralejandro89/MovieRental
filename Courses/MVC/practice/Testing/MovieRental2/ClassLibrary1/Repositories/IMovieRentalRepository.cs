using System.Collections.Generic;
using ClassLibrary1.Models;

namespace ClassLibrary1.Repositories
{
    public interface IMovieRentalRepository
    {
        // call this when you rent or return a movie
        void Save(MovieRental movieRental);
        List<MovieRental> GetRentedMoviesByCustomer(int customerId);
    }
}