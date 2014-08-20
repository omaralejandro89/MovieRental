using System.Collections.Generic;

namespace Unexpo.Models.Department
{
    public class AllDepartmentsView
    {
        public List<AllDepartmentsViewModel> Departments { get; set; }
        public AllDepartmentsDetailsViewModel AllDepartmentsDetailsViewModel { get; set; }

   
    }

    public class AllDepartmentsDetailsViewModel
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }

    public class AllDepartmentsViewModel
    {
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }
        public string DepartmentName { get; set; }
    }
}