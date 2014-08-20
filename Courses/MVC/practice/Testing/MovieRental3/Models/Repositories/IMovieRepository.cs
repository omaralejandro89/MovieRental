using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace Models.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovieByIdMovie(int id);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Delete(int movieId);
    }
}
