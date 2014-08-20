using System.Collections.Generic;
using System.Data;
using System.Linq;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;

namespace Unexpo.Repositories.EntityFramework
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Department GetDepartmentById(int departmentId)
        {
            using (var db = new UnexpoDb())
            {
                var department = db.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
                return department;
            }
        }

        public List<Department> GetAllDepartments()
        {
            using (var db = new UnexpoDb())
            {
                return db.Departments.ToList();
            }
        }

        public void Insert(Department department)
        {
            using (var db = new UnexpoDb())
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }

        public void Update(Department department)
        {
            using (var db = new UnexpoDb())
            {
                db.Entry(department).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int departmentId)
        {
            using (var db = new UnexpoDb())
            {
                var department = db.Departments.Find(departmentId);
                db.Entry(department).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}