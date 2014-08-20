using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practicing.Models
{
    public class PracticingDb : DbContext
    {
        public PracticingDb() : base("Practicing")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}