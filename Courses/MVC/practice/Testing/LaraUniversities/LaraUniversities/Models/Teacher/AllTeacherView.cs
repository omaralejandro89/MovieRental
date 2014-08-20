using System.Collections.Generic;

namespace LaraUniversities.Models.Teacher
{
    public class AllTeacherView
    {
        public List<TeacherViewModel> Teachers { get; set; }

    }

    public class TeacherViewModel
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}