using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaraUniversities.Models.Teacher;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;

namespace LaraUniversities.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public ActionResult Index()
        {
            var teachers = _teacherRepository.GetAllTeachers();

            var allTeacherView = new AllTeacherView();

            allTeacherView.Teachers = new List<TeacherViewModel>();
            foreach (var teacher in teachers)
            {
                TeacherViewModel teacherViewModel = new TeacherViewModel
                {
                    TeacherId = teacher.TeacherId,
                    TeacherName = teacher.TeacherName
                };
                allTeacherView.Teachers.Add(teacherViewModel);
            }

            return View(allTeacherView);
        }

        public ActionResult Edit(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }

        [HttpPost]
        public ActionResult Edit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherRepository.Update(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        public ActionResult Delete(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
                            _teacherRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }
    }
}
