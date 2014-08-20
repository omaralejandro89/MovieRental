using System.Collections.Generic;
using Unexpo.Core.Models;

namespace Unexpo.Core.Repositories
{
    public interface IDepartmentRepository
    {
        Department GetDepartmentById(int departmentId);
        List<Department> GetAllDepartments();
        void Insert(Department department);
        void Update(Department department);
        void Delete(int departmentId);
    }
}