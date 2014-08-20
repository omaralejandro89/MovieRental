using System.Data.Entity;
using ClassLibrary1.Models;

namespace MovieRental2.Repositories.EntityFramework
{
    public class MovieRental2Db : DbContext
    {
        public MovieRental2Db() : base("MovieRental2")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}