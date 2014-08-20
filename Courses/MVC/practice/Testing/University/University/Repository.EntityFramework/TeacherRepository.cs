using System.Collections.Generic;
using System.Linq;
using University.Core.Models;
using University.Core.Repositories;

namespace University.Repository.EntityFramework
{
    public class TeacherRepository : ITeacherRepository
    {
        public List<Teacher> GetAllTeachersByUniversityId(int universityId)
        {
            var teachers = new List<Teacher>();

            using (var db = new UniversityDb())
            {
                var workplaces = db.Workplaces.Where(x => x.UniversityId == universityId).ToList();
                foreach (var workplace in workplaces)
                {
                    var teacher = db.Teachers.FirstOrDefault(x => x.TeacherId == workplace.TeacherId);
                    teachers.Add(teacher);
                }
            }

            return teachers;
        }
    }
}