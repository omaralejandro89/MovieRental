using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Models;
using Models.Models;

namespace MovieRental3.Repositories.EntityFramework
{
    public class MovieRental3Db : DbContext
    {
        public MovieRental3Db() : base("MovieRental3")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieAlquilada> MovieAlquiladas { get; set; }
    }
}