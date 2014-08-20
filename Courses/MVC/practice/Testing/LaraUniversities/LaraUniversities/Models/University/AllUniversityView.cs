using System.Collections.Generic;

namespace LaraUniversities.Models.University
{
    public class AllUniversityView
    {
        public List<UniversityViewModel> Universities { get; set; }
    }

    public class UniversityViewModel
    {
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
        public int Telephone { get; set; }
    }
}