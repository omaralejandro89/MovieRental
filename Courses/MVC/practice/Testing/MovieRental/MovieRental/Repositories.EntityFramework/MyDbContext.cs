using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieRental.Core;
using MovieRental.Core.Models;

namespace MovieRental.Repositories.EntityFramework
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MovieRental")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}