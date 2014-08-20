using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;

namespace LaraUniversities.Repository.EntityFramework
{
    public class UniversityRepository : IUniversityRepository
    {
        public University GetUniversityById(int universityId)
        {
            using (var db = new UniversityLaraDb())
            {
                var university = db.Universities.FirstOrDefault(x => x.UniversityId == universityId);
                return university;
            }
        }

        public List<University> GetAllUniversities()
        {
            using (var db = new UniversityLaraDb())
            {
                var universities = db.Universities.ToList();
                return universities;
            }
        }

        public void Insert(University university)
        {
            using (var db = new UniversityLaraDb())
            {
                db.Universities.Add(university);
                db.SaveChanges();
                
            }
        }

        public void Update(University university)
        {
            using (var db = new UniversityLaraDb())
            {
                db.Entry(university).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int universityId)
        {
            using (var db = new UniversityLaraDb())
            {
                var university = db.Universities.Find(universityId);
                db.Entry(university).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public University GetUniversityByTeacherId(int teacherId)
        {
            throw new System.NotImplementedException();
        }
    }
}