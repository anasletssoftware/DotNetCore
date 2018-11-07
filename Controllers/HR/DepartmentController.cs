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
    public class DepartmentController : Controller
    {
        public IDepartment _GetDept;

        private ERPDbContext db;

        public DepartmentController(IDepartment _GetDept, ERPDbContext db)
        {
            this.db = db;
            // this._GetDept = _GetDept;
            this._GetDept = _GetDept;
        }
        public IActionResult Index()
        {
           var list = _GetDept.GetAll().ToList();
            return View(list);
        }
        public IActionResult Details(int id)
        {
            var GetDept = _GetDept.GetById(id);
            return View(GetDept);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            _GetDept.Insert(department);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var get = _GetDept.GetById(id);
            return View(get);
        }
        [HttpPost]
        public IActionResult Edit(Department model)
        {
            _GetDept.Update(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult delete(int id)
        {
            var data = _GetDept.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult delete(Department model, int id)
        {

            model.DepartmentId = id;
            var data = _GetDept.GetById(id);
            
            data.IsDeleted = true;
            _GetDept.Update(data);
            return RedirectToAction("Index");
        }


    }
}