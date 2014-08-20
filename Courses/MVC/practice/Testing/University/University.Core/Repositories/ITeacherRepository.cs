using System.Collections.Generic;
using University.Core.Models;

namespace University.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeachersByUniversityId(int universityId);
    }
}