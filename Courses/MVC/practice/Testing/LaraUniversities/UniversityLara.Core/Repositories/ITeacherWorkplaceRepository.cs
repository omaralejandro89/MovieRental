using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLara.Core.Models;

namespace UniversityLara.Core.Repositories
{
    public interface ITeacherWorkplaceRepository
    {
        List<Teacher> GetTeachersByUniversityId(int universityId);
    }
}
