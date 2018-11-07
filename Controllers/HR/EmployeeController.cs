using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;
using ImadErp.Services.HR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImadErp.Controllers.HR
{
    public class EmployeeController : Controller
    {
        public IEmployee _GetEmployee;

        private ERPDbContext db;

        public EmployeeController(IEmployee _GetEmployee, ERPDbContext db)
        {
            this.db = db;
            this._GetEmployee= _GetEmployee;
        }

        public IActionResult Index()
        {
            //from service
            var All = _GetEmployee.GetAll().ToList();

            if (_GetEmployee.GetAll().Equals(null))
            {
                return Json("No Active Data Found");
            }
            else
            { 
            return View(All);
            }
        }
        public IActionResult Details(int id)
        {
            var GetEmp = _GetEmployee.GetById(id);
            return View(GetEmp);
        }
        public IActionResult Create()
        {
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "Job_Title");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Department_Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            _GetEmployee.Insert(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "Job_Title");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Department_Name");
            var get = _GetEmployee.GetById(id);
            return View(get);
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            _GetEmployee.Update(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult delete(int id)
        {
            var data = _GetEmployee.GetById(id);
            return View(data);
        }





        [HttpPost]
        public IActionResult delete(Employee model, int id)
        {
           
            model.EmployeeId = id;
            var data = _GetEmployee.GetById(id);
            
            data.IsDeleted = true;
            _GetEmployee.Update(data);
            return RedirectToAction("Index");
        }
        
    }
}