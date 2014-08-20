using System.Data.Entity;
using University.Core.Models;

namespace University.Repository.EntityFramework
{
    public class UniversityDb : DbContext
    {

        public UniversityDb() : base("UniversityDb")
        {
            
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Core.Models.University> Universities { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
    }
}