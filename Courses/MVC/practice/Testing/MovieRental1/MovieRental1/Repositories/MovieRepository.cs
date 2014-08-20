using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental1.Core.Models;
using MovieRental1.Core.Repositories;

namespace MovieRental1.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Core.Models.Movie GetMovieById(int id)
        {
            var db = new MovieRental1Db();
            Movie movie = db.Movies.FirstOrDefault(b => b.MovieId == id);

            return movie;
        }

        public List<Core.Models.Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Models.Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Save(Core.Models.Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}