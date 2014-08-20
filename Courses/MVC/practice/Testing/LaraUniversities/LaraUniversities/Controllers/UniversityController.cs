using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaraUniversities.Models.University;
using UniversityLara.Core.Models;
using UniversityLara.Core.Repositories;

namespace LaraUniversities.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUniversityRepository _universityRepository;

        public UniversityController(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }


        public ActionResult Index()
        {
            var universities = _universityRepository.GetAllUniversities();
            AllUniversityView allUniversityView = new AllUniversityView();

            allUniversityView.Universities = new List<UniversityViewModel>();
            foreach (var university in universities)
            {
                UniversityViewModel universityViewModel = new UniversityViewModel
                {
                    UniversityId = university.UniversityId,
                    UniversityName = university.UniversityName,
                    Telephone = university.Telephone
                    
                };
                allUniversityView.Universities.Add(universityViewModel);
            }

            return View(allUniversityView);
        }


        public ActionResult Create()
        {
            var university = new University();
            return View(university);
        }

        [HttpPost]
        public ActionResult Create(University university)
        {
            if (ModelState.IsValid)
            {
                _universityRepository.Insert(university);
                return RedirectToAction("Index");
            }
            return View(university);
        }

        public ActionResult Edit(int id)
        {
            var university = _universityRepository.GetUniversityById(id);
            return View(university);
        }

        [HttpPost]
        public ActionResult Edit(University university)
        {
            if (ModelState.IsValid)
            {
                _universityRepository.Update(university);
                return RedirectToAction("Index");
            }
            return View(university);
        }

        public ActionResult Delete(int id)
        {
            var university = _universityRepository.GetUniversityById(id);
            return View(university);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
                var university = _universityRepository.GetUniversityById(id);
                _universityRepository.Delete(id);
                return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            var university = _universityRepository.GetUniversityById(id);
            return View(university);
        }
    }
}
