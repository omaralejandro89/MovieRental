using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental1.Core.Models;

namespace MovieRental1.Core.Repositories
{
    public interface IMovieRepository
    {
        Movie GetMovieById(int id);
        List<Movie> GetAll();
        void Update(Movie movie);
        void Save(Movie movie);
    }
}
