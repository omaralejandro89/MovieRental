using System.Collections.Generic;

namespace Unexpo.Models.Teacher
{
    public class AllTeachersView
    {
        public List<AllTeachersViewModel> Teachers { get; set; }
        public AllTeachersDetailViewModel AllTeachersDetailViewModel { get; set; }
    }

    public class AllTeachersDetailViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class AllTeachersViewModel
    {
        public int TeacherId { get; set; }
        public int DepartmentId { get; set; }
        public string TeacherName { get; set; }
        public string DepartmentName { get; set; }
    }
}