using System.Collections.Generic;

namespace MovieRental.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}
