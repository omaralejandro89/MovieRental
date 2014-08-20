using System.Collections.Generic;
using UniversityLara.Core.Models;

namespace UniversityLara.Core.Repositories
{
    public interface IUniversityRepository
    {
        University GetUniversityById(int universityId);
        List<University> GetAllUniversities();
        void Insert(University university);
        void Update(University university);
        void Delete(int universityId);
        University GetUniversityByTeacherId(int teacherId);
    }
}