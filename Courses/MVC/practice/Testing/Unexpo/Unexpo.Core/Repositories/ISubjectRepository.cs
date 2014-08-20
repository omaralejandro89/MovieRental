using System.Collections.Generic;
using Unexpo.Core.Models;

namespace Unexpo.Core.Repositories
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjectsByTeacherId(int teacherId);
        List<Subject> GetAllSubjects();
        Subject GetSubjectById(int subjectId);
        void Intert(Subject subject);
        void Update(Subject subject);
        void Delete(int subjectId);
    }
}