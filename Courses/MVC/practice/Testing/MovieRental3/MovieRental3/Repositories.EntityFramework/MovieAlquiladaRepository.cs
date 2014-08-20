using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models;
using Models.Repositories;

namespace MovieRental3.Repositories.EntityFramework
{
    public class MovieAlquiladaRepository : IMovieAlquiladaRepository
    {
        public List<MovieAlquilada> GetMoviesAlquiladasByCustomer(int customerId)
        {
            using (var db = new MovieRental3Db())
            {
                var alquiladas = db.MovieAlquiladas.Where(x => x.CustomerId == customerId).ToList();
                return alquiladas;
            }
        }


    }
}