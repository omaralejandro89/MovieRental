using System.Collections.Generic;

namespace Unexpo.Models.Subject
{
    public class AllSubjectsByTeacherIdView
    {
        public List<AllSubjectsByTeacherIdViewModel> SubjectsByTeacherId { get; set; }
        public AllSubjectsDetailViewModel AllSubjectsDetailViewModel { get; set; }
    }

    public class AllSubjectsDetailViewModel
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string SubjectName { get; set; }
        public int DepartmentId { get; set; }
    }

    public class AllSubjectsByTeacherIdViewModel
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}