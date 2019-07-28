using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepartmentMVCApp.Services;
using DepartmentMVCApp.Models.Deapartment;
using DepartmentMVCApp.Filter;

namespace DepartmentMVCApp.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService _service;
        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }
        // GET: Department
        [CustomLogger]
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.DepartmentList = _service.GetDepartmentList();
            vm.Count = _service.GetCount();
            return View(vm);
        }

        [Authorize]
        [HttpGet]
        [CustomLogger]
        public ActionResult Add()
        {
            AddViewModel addvm = new AddViewModel();
            return View(addvm);
        }

        [HttpPost]
        [CustomLogger]
        public ActionResult Add(AddViewModel addvm)
        {
            if (!ModelState.IsValid)
            {
                return View(addvm);
            }

            _service.AddNewDepartment(_service.ConvertVMToDept(addvm.Name, addvm.Location));
            return RedirectToAction("Index");
        }

        [HttpGet]
        [CustomLogger]
        public ActionResult Edit(Guid id)
        {
            EditViewModel editvm = new EditViewModel();
            editvm.Id = id;
            var dept = _service.GetDepartmentById(id);
            editvm.Name = dept.Dname;
            editvm.Location = dept.Location;
            return View(editvm);
        }

        [HttpPost]
        [CustomLogger]
        public ActionResult Edit(EditViewModel editvm)
        {
            if (!ModelState.IsValid)
            {
                return View(editvm);
            }

            _service.EditDepartmentDetails(editvm.Id, _service.ConvertVMToDept(editvm.Name, editvm.Location));
            return RedirectToAction("Index");
        }

    }

}