using System.Data.Entity;
using Unexpo.Core.Models;

namespace Unexpo.Repositories.EntityFramework
{
    public class UnexpoDb : DbContext
    {
        public UnexpoDb() : base("Unexpo")
        {
            
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}