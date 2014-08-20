using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Ajax.Utilities;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;

namespace LaraUniversities.Repository.EntityFramework
{
    public class TeacherRepository : ITeacherRepository
    {
        public Teacher GetTeacherById(int teacherId)
        {
            using (var db = new UniversityLaraDb())
            {
                var teacher = db.Teachers.FirstOrDefault(x => x.TeacherId == teacherId);
                return teacher;
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            using (var db = new UniversityLaraDb())
            {
                var teachers = db.Teachers.ToList();
                return teachers;
            }
        }

        public void Insert(Teacher teacher)
        {
            using (var db = new UniversityLaraDb())
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }
        }

        public void Update(Teacher teacher)
        {
            using (var db = new UniversityLaraDb())
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int teacherId)
        {
            using (var db = new UniversityLaraDb())
            {
                var teacher = db.Teachers.Find(teacherId);
                db.Entry(teacher).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}