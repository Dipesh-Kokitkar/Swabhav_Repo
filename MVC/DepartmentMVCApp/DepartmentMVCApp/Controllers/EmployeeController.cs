using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepartmentMVCApp.Models.Employee;
using DepartmentMVCApp.Services;
using DepartmentMVCApp.Filter;

namespace DepartmentMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService _service;
        public EmployeeController()
        {
            _service = new EmployeeService();
        }
        // GET: Employee
        [CustomLogger]
        public ActionResult Index(Guid id)
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Id = id;
            vm.EmployeeList = _service.GetEmployeeList(_service.GetDepartmentById(id));
            vm.Count = _service.Count(_service.GetDepartmentById(id));
            return View(vm);
        }

        [CustomLogger]
        [HttpGet]
        public ActionResult Add(Guid id)
        {
            AddViewModel addmodel = new AddViewModel();
            addmodel.Id = id;
            addmodel.departments = _service.DepartmentNames();
            return View(addmodel);
        }

        [HttpPost]
        [CustomLogger]
        public ActionResult Add(AddViewModel addvm)
        {
            if (!ModelState.IsValid)
            {
                return View(addvm);
            }

            var employee = _service.ConvertVMToEmp(addvm.Name, addvm.Salary, addvm.Comission, addvm.DateofJoin);
            _service.AddNewEmployee(employee, _service.GetDepartmentByName(addvm.SelectedDepartment));
            return RedirectToAction("Index", new { Id = addvm.Id });
        }


        [HttpGet]
        [CustomLogger]
        public ActionResult Edit(Guid id)
        {
            EditViewModel editvm = new EditViewModel();
            editvm.Id = id;
            var emp = _service.GetEmpById(editvm.Id);

            editvm.Name = emp.EName;
            editvm.Salary = emp.Salary.ToString();
            editvm.Comission = emp.Comission.ToString();
            editvm.DateofJoin = emp.DateOfJoin;
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

            var id = _service.EditEmployeeData(editvm.Id, _service.ConvertVMToEmp(editvm.Name, editvm.Salary, editvm.Comission,
                editvm.DateofJoin));
            return RedirectToAction("Index", "Employee", new { Id = id });
        }

        public ActionResult ShowAll() {
            ShowAllViewModel showvm = new ShowAllViewModel();
            showvm.EmployeesList = _service.GetAllEmployees();
            showvm.Count = _service.GetTotalEmployeeCount();
            return View(showvm);
        }
    }
}