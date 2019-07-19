using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVCApp.Services;
using EmployeeMVCApp.Models.Department;

namespace EmployeeMVCApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        private DepartmentService _service;

        public DepartmentController()
        {
            _service = new DepartmentService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.FilterList = _service.LoadEmployeeData();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel vm)
        {
            int id = _service.GetIdByName(vm.SelectedDepartment.ToString());
            vm.FilterList=_service.GetEmployeeByDeptno(id);
            return View(vm);
        }
    }
}