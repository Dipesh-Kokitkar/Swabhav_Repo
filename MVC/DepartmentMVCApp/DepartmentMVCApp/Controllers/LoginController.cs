using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepartmentMVCApp.Models.Login;
using DepartmentMVCApp.Services;
using DepartmentMVCApp.Filter;

namespace DepartmentMVCApp.Controllers
{
    public class LoginController : Controller
    {
        private AuthenitactionService _service;

        public LoginController() {
            _service = new AuthenitactionService();
        }
        // GET: Login
        [HttpGet]
        [CustomLogger]
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            return View(vm);
        }

        [HttpPost]
        [CustomLogger]
        public ActionResult Index(IndexViewModel vm) {
            if (!ModelState.IsValid) {
                return View(vm);
            }

            if (_service.Validate(vm.Username, vm.Password))
            {
                return RedirectToAction("Add","Department");
            }
            return RedirectToAction("Index","Department");
        }

        [CustomLogger]
        public ActionResult Logout() {
            _service.Logout();
            return RedirectToAction("Index","Department");
        }
    }
}