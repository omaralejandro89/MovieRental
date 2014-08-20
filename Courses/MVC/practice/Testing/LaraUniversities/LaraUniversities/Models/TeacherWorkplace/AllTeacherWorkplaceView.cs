using System.Collections.Generic;

namespace LaraUniversities.Models.TeacherWorkplace
{
    public class AllTeacherWorkplaceView
    {
        public List<TeacherWorkplaceViewModel> TeacherWorkplaces { get; set; }
        public TeacherWorkPlaceDetailsViewModel TeacherWorkPlaceDetailsViewModel { get; set; }
    }

    public class TeacherWorkPlaceDetailsViewModel
    {
        public int TeacherWorkplaceId { get; set; }
        public int TeacherId { get; set; }
        public int UniversityId { get; set; }
    }

    public class TeacherWorkplaceViewModel
    {
        public int TeacherWorkplaceId { get; set; }
        public int TeacherId { get; set; }
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
        public string TeacherName { get; set; }
    }
}