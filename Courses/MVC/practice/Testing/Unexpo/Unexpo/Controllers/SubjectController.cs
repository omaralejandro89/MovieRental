using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;
using Unexpo.Models.Subject;

namespace Unexpo.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly ITeacherRepository _teacherRepository;

        public SubjectController(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository)
        {
            _subjectRepository = subjectRepository;
            _teacherRepository = teacherRepository;
        }

        public ActionResult Index()
        {
            return Content("Index page!");
        }

        public ActionResult SubjectsByTeacherId(int teacherId)
        {
            var subjectsByTeacherId = _subjectRepository.GetSubjectsByTeacherId(teacherId);

            var allSubjectsByTeacherIdView = new AllSubjectsByTeacherIdView();

            var teacherSingle = _teacherRepository.GetTeacherById(teacherId);
            allSubjectsByTeacherIdView.AllSubjectsDetailViewModel = new AllSubjectsDetailViewModel
            {
                TeacherId = teacherSingle.TeacherId,
                TeacherName = teacherSingle.TeacherName,
                DepartmentId = teacherSingle.DepartmentId
            };



            allSubjectsByTeacherIdView.SubjectsByTeacherId = new List<AllSubjectsByTeacherIdViewModel>();
            foreach (var subject in subjectsByTeacherId)
            {
                AllSubjectsByTeacherIdViewModel allSubjectsByTeacherIdViewModel = new AllSubjectsByTeacherIdViewModel
                {
                    SubjectId = subject.SubjectId,
                    SubjectName = subject.SubjectName,
                    TeacherId = subject.TeacherId,
                };

                var teacher = _teacherRepository.GetTeacherById(subject.TeacherId);
                if (teacher != null)
                {
                    allSubjectsByTeacherIdViewModel.TeacherName = teacher.TeacherName;
                }
                allSubjectsByTeacherIdView.SubjectsByTeacherId.Add(allSubjectsByTeacherIdViewModel);
            }

            return View(allSubjectsByTeacherIdView);


        }

        public ActionResult Edit(int id)
        {
            var subject = _subjectRepository.GetSubjectById(id);
            return View(subject);
        }

        [HttpPost]
        public ActionResult Edit(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _subjectRepository.Update(subject);
                return RedirectToAction("SubjectsByTeacherId", new {id = subject.TeacherId});
            }
            return View(subject);
        }

    }
}
