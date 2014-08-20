using System.Collections.Generic;
using System.Data;
using System.Linq;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;

namespace Unexpo.Repositories.EntityFramework
{
    public class SubjectRepository : ISubjectRepository
    {
        public List<Subject> GetSubjectsByTeacherId(int teacherId)
        {
            using (var db = new UnexpoDb())
            {
                var subjectsByTeacherId = db.Subjects.Where(x => x.TeacherId == teacherId).ToList();
                return subjectsByTeacherId;
            }
        }

        public List<Subject> GetAllSubjects()
        {
            using (var db = new UnexpoDb())
            {
                return db.Subjects.ToList();
            }
        }

        public Subject GetSubjectById(int subjectId)
        {
            using (var db = new UnexpoDb())
            {
                var subject = db.Subjects.FirstOrDefault(x => x.SubjectId == subjectId);
                return subject;
            }
        }

        public void Intert(Subject subject)
        {
            using (var db = new UnexpoDb())
            {
                db.Subjects.Add(subject);
                db.SaveChanges();
            }
        }

        public void Update(Subject subject)
        {
            using (var db = new UnexpoDb())
            {
                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int subjectId)
        {
            using (var db = new UnexpoDb())
            {
                var subject = db.Subjects.Find(subjectId);
                db.Entry(subject).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}