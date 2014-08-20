using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MovieRental.Core.Repositories;

namespace MovieRental.Repositories.EntityFramework
{
    public class MovieRepository : IMovieRepository
    {
        readonly MyDbContext _db = new MyDbContext();

        public Core.Models.Movie   GetByMovieId(int id)
        {
            var movie = _db.Movies.FirstOrDefault(m => m.MovieId == id);
            return movie;
        }

        public List<Core.Models.Movie> GetAllMovies()
        {
            return _db.Movies.ToList();
        }

        public void Insert(Core.Models.Movie movie)
        {
            _db.Movies.Add(movie);
        }

        public void Update(Core.Models.Movie movie)
        {
            _db.Entry(movie).State = EntityState.Modified;
        }

        public void Save(Core.Models.Movie movie)
        {
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            _db.Movies.Remove(movie);
        }
    }
}