using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;
using ImadErp.Services.HR;
using Microsoft.AspNetCore.Mvc;

namespace ImadErp.Controllers.HR
{
    public class JobController : Controller
    {
        public IJob _GetJobs;

        private ERPDbContext db;

        public JobController(IJob _GetJobs, ERPDbContext db)
        {
            this.db = db;
            // this._GetDept = _GetDept;
            this._GetJobs = _GetJobs;
        }
        public IActionResult Index()
        {
            var list = _GetJobs.GetAll().ToList();
            return View(list);
        }
        public IActionResult Details(int id)
        {
            var Getid = _GetJobs.GetById(id);
            return View(Getid);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Job model)
        {
            _GetJobs.Insert(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var get = _GetJobs.GetById(id);
            return View(get);
        }
        [HttpPost]
        public IActionResult Edit(Job model)
        {
            _GetJobs.Update(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult delete(int id)
        {
            var data = _GetJobs.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult delete(Job model, int id)
        {

            model.JobId = id;
            var data = _GetJobs.GetById(id);

            data.IsDeleted = true;
            _GetJobs.Update(data);
            return RedirectToAction("Index");
        }
    }
}