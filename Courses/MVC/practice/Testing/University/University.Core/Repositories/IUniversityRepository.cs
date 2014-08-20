using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Core.Repositories
{
    interface IUniversityRepository
    {
        Models.University GetUniversityById(int universityId);
        List<Models.University> GetAllUniversities();
        Models.University Insert(Models.University university);
        Models.University Update(int universityId);
    }
}
