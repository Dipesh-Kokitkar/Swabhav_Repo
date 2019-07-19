using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Services;
using WelcomeMVCApp.Models.Student;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private StudentServices _service;
        public StudentController()
        {
            _service = new StudentServices();
        }

        public ActionResult Index()
        {
            IndexViewModel indexmodel = new IndexViewModel();
            indexmodel.Count = _service.GetCount();
            indexmodel.Students = _service.GetStudents();
            return View(indexmodel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddViewModel addmodel = new AddViewModel();
            bool isloggedin =Convert.ToBoolean(Session["Isloggedin"]);
            if (!isloggedin) {
                return RedirectToAction("Index","Login");
            }
            return View(addmodel);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel addmodel)
        {
            if (string.IsNullOrEmpty(addmodel.StudentRollno)|| string.IsNullOrEmpty(addmodel.StudentName) ||
                 string.IsNullOrEmpty(addmodel.StudentDOB) || string.IsNullOrEmpty(addmodel.StudentCGPA) ||
                 string.IsNullOrEmpty(addmodel.StudentLocation))
            {
                addmodel.Error = "Plz fill all the fields!";
                return View(addmodel);
            }
            _service.AddNewStudent(_service.ConvertVMToStudent(addmodel.StudentRollno, addmodel.StudentName,
                addmodel.StudentDOB, addmodel.StudentCGPA, addmodel.StudentLocation));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int rollno)
        {
            bool isloggedin = Convert.ToBoolean(Session["Isloggedin"]);
            if (!isloggedin)
            {
                return RedirectToAction("Index", "Login");
            }
            EditViewModel vm = new EditViewModel();
            var student = _service.GetStudentByRollno(rollno);
            if (student != null) {
                vm.StudentRollno = student.Rollno.ToString();
                vm.StudentName = student.Name;
                vm.StudentDOB = student.Birthdate.ToString();
                vm.StudentCGPA = student.CGPA.ToString();
                vm.StudentLocation = student.Location;
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel vm) {

            if ( string.IsNullOrEmpty(vm.StudentName) ||
                 string.IsNullOrEmpty(vm.StudentDOB) || string.IsNullOrEmpty(vm.StudentCGPA) ||
                 string.IsNullOrEmpty(vm.StudentLocation))
            {
                vm.Error = "Plz fill all the fields!";
                return View(vm);
            }

            _service.EditStudent(_service.ConvertVMToStudent(vm.StudentRollno, vm.StudentName,vm.StudentDOB,
                vm.StudentCGPA,vm.StudentLocation));

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int rollno) {
            bool isloggedin = Convert.ToBoolean(Session["Isloggedin"]);
            if (!isloggedin)
            {
                return RedirectToAction("Index", "Login");
            }
            Student student = _service.GetStudentByRollno(rollno);
            if (student != null)
            {
                _service.DeleteStudent(student);
            }
            return RedirectToAction("Index");
        }

    }
}