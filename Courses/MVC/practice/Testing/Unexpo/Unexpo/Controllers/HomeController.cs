using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unexpo.Core.Models;
using Unexpo.Core.Repositories;
using Unexpo.Models.Department;

namespace Unexpo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public HomeController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public ActionResult Index()
        {
            var departments = _departmentRepository.GetAllDepartments();

            var allDepartmentsView = new AllDepartmentsView();

            allDepartmentsView.AllDepartmentsDetailsViewModel = new AllDepartmentsDetailsViewModel
            {

            };

            allDepartmentsView.Departments = new List<AllDepartmentsViewModel>();
            foreach (var department in departments)
            {
                var allDepartmentsViewModel = new AllDepartmentsViewModel
                {
                    DepartmentId = department.DepartmentId,
                    DepartmentName = department.DepartmentName
                };
                allDepartmentsView.Departments.Add(allDepartmentsViewModel);
            }

            return View(allDepartmentsView);
        }


        public ActionResult Create()
        {
            var department = new Department();
            return View(department);
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Insert(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public ActionResult Edit(int id)
        {
            var departement = _departmentRepository.GetDepartmentById(id);
            return View(departement);
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Update(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public ActionResult Delete(int id)
        {
            var department = _departmentRepository.GetDepartmentById(id);
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var department = _departmentRepository.GetDepartmentById(id);
            _departmentRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
