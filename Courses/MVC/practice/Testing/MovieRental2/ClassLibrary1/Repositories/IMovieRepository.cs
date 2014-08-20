using System.Collections.Generic;
using ClassLibrary1.Models;

namespace ClassLibrary1.Repositories
{
    public interface IMovieRepository
    {
        Movie GetByIdMovie(int id);
        List<Movie> GetAllMovies();
        void Update(Movie movie);
        void Save(Movie movie);
        List<Movie> GetMoviesRentedByCustomer(int customerId);
    }
}