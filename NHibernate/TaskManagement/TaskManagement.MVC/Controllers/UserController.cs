using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagement.MVC.Models.User;
using TaskManagement.MVC.Services;

namespace TaskManagement.MVC.Controllers
{
    public class UserController : Controller
    {
        private UserService _userservice;
        private TaskService _taskservice;

        public UserController() {
            _userservice = new UserService();
            _taskservice = new TaskService();
        }
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel vm) {
            if (ModelState.IsValid)
            {
                if (_userservice.ValidateUser(vm.Username, vm.Password))
                {
                    return RedirectToAction("Home", "User", new { User = vm.Username });
                }
            }
            vm.Error = "Please Enter Valid Username or Password";
            return View(vm);
        }

        [HttpGet]
        public ActionResult Register() {
            RegisterViewModel registervm = new RegisterViewModel();
            return View(registervm);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel registervm) {
            if (ModelState.IsValid)
            {
                var user = _userservice.ConvertVMToUser(0, registervm.Name, registervm.Password, registervm.MobileNumber,
                    registervm.Email);
                _userservice.AddNewUser(user);
                return RedirectToAction("Index","User");
            }
            return View(registervm);
        }

        public ActionResult Home(string user) {
            HomeViewModel homevm = new HomeViewModel();
            homevm.CurrentUser = user;
            homevm.UserId = _userservice.GetUserByName(user).Id;
            homevm.UserTaskList = _taskservice.GetAllUserTasks(_userservice.GetUserByName(user));
            return View(homevm);
        }
    }
}