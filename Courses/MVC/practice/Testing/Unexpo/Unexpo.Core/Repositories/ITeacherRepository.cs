using System.Collections.Generic;
using Unexpo.Core.Models;

namespace Unexpo.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeachers();
        List<Teacher> GetTeachersByDepartmentId(int departmentId);
        Teacher GetTeacherById(int teacherId);
        void Insert(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int teacherId);
    }
}