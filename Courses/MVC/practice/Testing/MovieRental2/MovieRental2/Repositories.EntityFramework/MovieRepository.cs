using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;

namespace MovieRental2.Repositories.EntityFramework
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            using (var db = new MovieRental2Db())
            {
                return db.Movies.ToList();
            }
        }

        public Movie GetByIdMovie(int id)
        {
            using (var db = new MovieRental2Db())
            {
                Movie movie = db.Movies.FirstOrDefault(m => m.MovieId == id);
                return movie;
            }
        }

        public void Save(Movie movie)
        {
            throw new NotImplementedException();
        }

        //public List<Movie> GetRentedMovies()
        //{
        ////    //using (var db = new MovieRental2Db())
        ////    //{
        ////        //var unreturnedMovieRentals = _db.MovieRentals.Where(x => x.DateReturned == null);

        ////        //var movies = _db.MovieRentals
        ////        //    .Select(rental => _db.Movies.FirstOrDefault(x => x.MovieId == rental.MovieId))
        ////        //    .ToList();

        ////        //return movies;
        ////    //}
        //    return View();
        //}

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }


        public List<Movie> GetMoviesRentedByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}