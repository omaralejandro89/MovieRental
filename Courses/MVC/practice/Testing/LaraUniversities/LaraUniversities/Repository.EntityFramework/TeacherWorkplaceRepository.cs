using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;
using WebGrease.Css.Extensions;

namespace LaraUniversities.Repository.EntityFramework
{

    public class TeacherWorkplaceRepository : ITeacherWorkplaceRepository
    {
        public List<Teacher> GetTeachersByUniversityId(int universityId)
        {
            var teachers = new List<Teacher>();

            using (var db = new UniversityLaraDb())
            {
                var teacherWorkplaces = db.TeacherWorkPlaces.Where(x => x.UniversityId == universityId).ToList();
                foreach (var teacherWorkplace in teacherWorkplaces)
                {
                    var teacher = db.Teachers.FirstOrDefault(x => x.TeacherId == teacherWorkplace.TeacherId);
                    teachers.Add(teacher);
                }
            }
            
            return teachers;
        }


    }
}