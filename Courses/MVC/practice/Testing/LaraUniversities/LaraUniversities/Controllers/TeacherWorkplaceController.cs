using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LaraUniversities.Models.TeacherWorkplace;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;

namespace LaraUniversities.Controllers
{
    public class TeacherWorkplaceController : Controller
    {
        private readonly ITeacherWorkplaceRepository _teacherWorkplaceRepository;
        private readonly IUniversityRepository _universityRepository;
        private readonly ITeacherRepository _teacherRepository;

        public TeacherWorkplaceController(ITeacherWorkplaceRepository teacherWorkplaceRepository, IUniversityRepository universityRepository, ITeacherRepository teacherRepository)
        {
            _teacherWorkplaceRepository = teacherWorkplaceRepository;
            _universityRepository = universityRepository;
            _teacherRepository = teacherRepository;
        }

        public ActionResult Index(int id)
        {
            var teachers = _teacherWorkplaceRepository.GetTeachersByUniversityId(id);
            var university = _universityRepository.GetUniversityById(id);
            
            var allTeacherWorkplaceView = new AllTeacherWorkplaceView();

            allTeacherWorkplaceView.TeacherWorkPlaceDetailsViewModel = new TeacherWorkPlaceDetailsViewModel
            {
                UniversityId = university.UniversityId
            };

            allTeacherWorkplaceView.TeacherWorkplaces = new List<TeacherWorkplaceViewModel>();
            foreach (var teacher in teachers)
            {
                TeacherWorkplaceViewModel teacherWorkplaceViewModel = new TeacherWorkplaceViewModel
                {
                    TeacherId = teacher.TeacherId,
                    TeacherName = teacher.TeacherName,
                    UniversityId = university.UniversityId,
                    UniversityName = university.UniversityName
                };
                allTeacherWorkplaceView.TeacherWorkplaces.Add(teacherWorkplaceViewModel);
            }


            return View(allTeacherWorkplaceView);


        }

        //public ActionResult Create(int universityId)
        //{
        //    var teacher = new Teacher();
        //    return View(teacher);
        //}

        //[HttpPost]
        //public ActionResult Create(Teacher teacher)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //        _teacherRepository.Insert(teacher);
        //        return RedirectToAction("Index", new { id = teacher});
        //    }
        //    return View(teacher);
        //}


        public ActionResult Create(int universityId)
        {
            var teacher = new Teacher();
            return View(teacher);
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher, int universityId)
        {
            if (ModelState.IsValid)
            {
                _teacherRepository.Insert(teacher);
                
                return RedirectToAction("Index", new { id = universityId });
            }
            return View(teacher);
        }

        public ActionResult Edit(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }

        //[HttpPost]
        //public ActionResult Edit(Teacher teacher)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _teacherRepository.Update(teacher);
        //        return RedirectToAction("Index", new { id = })
        //    }
        //}
    }
}
