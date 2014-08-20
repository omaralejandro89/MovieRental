using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;
using Unexpo.Models.Teacher;

namespace Unexpo.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public TeacherController(ITeacherRepository teacherRepository, IDepartmentRepository departmentRepository)
        {
            _teacherRepository = teacherRepository;
            _departmentRepository = departmentRepository;
        }

        public ActionResult Index()
        {
            var teachers = _teacherRepository.GetAllTeachers();
            return View(teachers);
        }

        public ActionResult TeachersByDepartmentId(int id)
        {
            var teachers = _teacherRepository.GetAllTeachers().Where(x => x.DepartmentId == id);

            var allTeachersView = new AllTeachersView();

            var departmentSingle = _departmentRepository.GetDepartmentById(id);
            allTeachersView.AllTeachersDetailViewModel = new AllTeachersDetailViewModel
            {
                DepartmentId = departmentSingle.DepartmentId,
                DepartmentName = departmentSingle.DepartmentName
            };

            allTeachersView.Teachers = new List<AllTeachersViewModel>();
            foreach (var teacher in teachers)
            {
                var allteachersViewModel = new AllTeachersViewModel
                {
                    TeacherId = teacher.TeacherId,
                    TeacherName = teacher.TeacherName,
                    DepartmentId = teacher.DepartmentId
                };

                var department = _departmentRepository.GetDepartmentById(teacher.DepartmentId);
                if (department != null)
                {
                    allteachersViewModel.DepartmentName = department.DepartmentName;
                }

                allTeachersView.Teachers.Add(allteachersViewModel);
            }

            return View(allTeachersView);


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
                return RedirectToAction("TeachersByDepartmentId", new {id = teacher.DepartmentId});
            }
            return View(teacher);
        }

        public ActionResult Create(int id)
        {
            var teacher = new Teacher
            {
                DepartmentId = id
            };
            return View(teacher);
        }


        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherRepository.Insert(teacher);
                return RedirectToAction("TeachersByDepartmentId", new {id = teacher.DepartmentId});
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
            return RedirectToAction("TeachersByDepartmentId", new { id = teacher.DepartmentId});
        }
    }
}
