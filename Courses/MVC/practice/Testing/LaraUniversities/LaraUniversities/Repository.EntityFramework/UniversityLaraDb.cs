using System.Data.Entity;
using UniversityLara.Core.Models;

namespace LaraUniversities.Repository.EntityFramework
{
    public class UniversityLaraDb: DbContext
    {
        public UniversityLaraDb(): base("UniversityLara")
        {
            
        }

        public DbSet<University> Universities { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherWorkPlace> TeacherWorkPlaces { get; set; }
    }
}