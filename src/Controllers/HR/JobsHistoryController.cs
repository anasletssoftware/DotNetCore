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
    public class JobsHistoryController : Controller
    {
        public IJobHistroy GetHistroy;
        private readonly ERPDbContext db;

        public JobsHistoryController(ERPDbContext db, IJobHistroy GetHistroy)
        {
            this.GetHistroy = GetHistroy;
            this.db = db;
        }

        public IActionResult Index()
        {
          var list = GetHistroy.GetJobHistories().ToList();
          return View(list);
        }
        public IActionResult Details(int id)
        {
            var Getid = GetHistroy.GetById(id);
            return View(Getid);
        }
        public IActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName");
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "Job_Title");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Department_Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobHistory model)
        {
            GetHistroy.Insert(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName");
            ViewBag.JobId = new SelectList(db.Jobs, "JobId", "Job_Title");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Department_Name");
            var get = GetHistroy.GetById(id);
            return View(get);
        }
        [HttpPost]
        public IActionResult Edit(JobHistory model)
        {
            GetHistroy.Update(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult delete(int id)
        {
            var data = GetHistroy.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult delete(JobHistory model, int id)
        {

            model.DepartmentId = id;
            var data = GetHistroy.GetById(id);

            data.IsDeleted = true;
            GetHistroy.Update(data);
            return RedirectToAction("Index");
        }
    }
}