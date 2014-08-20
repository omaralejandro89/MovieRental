using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using Models.Models;
using Models.Repositories;

namespace MovieRental3.Repositories.EntityFramework
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            using (var db = new MovieRental3Db())
            {
                return db.Movies.ToList();
            }
        }

        public Movie GetMovieByIdMovie(int id)
        {
            using (var db = new MovieRental3Db())
            {
                Movie movie = db.Movies.FirstOrDefault(x => x.MovieId == id);
                return movie;
            }
        }

        public void Insert(Movie movie)
        {
            using (var db = new MovieRental3Db())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }

        public void Update(Movie movie)
        {
            using (var db = new MovieRental3Db())
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int movieId)
        {
            using (var db = new MovieRental3Db())
            {
                var movie = new Movie {MovieId = movieId};
                db.Entry(movie).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}