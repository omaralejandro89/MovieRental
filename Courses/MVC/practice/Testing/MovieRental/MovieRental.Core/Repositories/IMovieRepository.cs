using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieRental.Core.Models;

namespace MovieRental.Core.Repositories
{
    public interface IMovieRepository
    {
        Movie GetByMovieId(int id);
        List<Movie> GetAllMovies();
        void Insert(Movie movie);
        void Update(Movie movie);
        void Save(Movie movie);
        void Delete(int id);
    }
}
