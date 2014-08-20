using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieRental1.Core.Models;
using MovieRental1.Core.Repositories;

namespace MovieRental1.Repositories
{
    public class MovieRental1Db : DbContext
    {

        public MovieRental1Db() : base("ConnectionToDataBase")
        {
            
        }

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Movie> Movies { get; set; }
    }
}