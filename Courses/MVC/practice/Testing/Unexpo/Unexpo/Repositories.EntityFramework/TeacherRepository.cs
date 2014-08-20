using System.Collections.Generic;
using System.Data;
using System.Linq;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;

namespace Unexpo.Repositories.EntityFramework
{
    public class TeacherRepository : ITeacherRepository
    {
        public List<Teacher> GetAllTeachers()
        {
            using (var db = new UnexpoDb())
            {
                return db.Teachers.ToList();
            }
        }

        public List<Teacher> GetTeachersByDepartmentId(int departmentId)
        {
            using (var db = new UnexpoDb())
            {
                var teachers = db.Teachers.Where(x => x.DepartmentId == departmentId).ToList();
                return teachers;
            }
        }

        public Teacher GetTeacherById(int teacherId)
        {
            using (var db = new UnexpoDb())
            {
                var teacher = db.Teachers.FirstOrDefault(x => x.TeacherId == teacherId);
                return teacher;
            }
        }

        public void Insert(Teacher teacher)
        {
            using (var db = new UnexpoDb())
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }
        }

        public void Update(Teacher teacher)
        {
            using (var db = new UnexpoDb())
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int teacherId)
        {
            using (var db = new UnexpoDb())
            {
                var teacher = db.Teachers.Find(teacherId);
                db.Entry(teacher).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}