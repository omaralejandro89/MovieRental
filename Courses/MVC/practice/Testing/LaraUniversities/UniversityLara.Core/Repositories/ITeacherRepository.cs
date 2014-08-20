using System.Collections.Generic;
using System.Security.Cryptography;
using UniversityLara.Core.Models;

namespace UniversityLara.Core.Repositories
{
    public interface ITeacherRepository
    {
        Teacher GetTeacherById(int teacherId);
        List<Teacher> GetAllTeachers();
        void Insert(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int teacherId);
    }
}