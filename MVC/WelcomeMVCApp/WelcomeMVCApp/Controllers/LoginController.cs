using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.Login;
using WelcomeMVCApp.Services;

namespace WelcomeMVCApp.Controllers
{
    public class LoginController : Controller
    {
        private AuthenticationService _authentication;
        public LoginController() {
            _authentication = new AuthenticationService();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel vm) {
            if (!ModelState.IsValid) {
                return View(vm);
            }
            bool result = _authentication.Validate(vm.Username,vm.Password);
            if (result)
            {
                Session["Isloggedin"] = true;
            }
            return RedirectToAction("Index", "Student");
        }

        public ActionResult Logout() {
            if (Convert.ToBoolean(Session["Isloggedin"]) == true) {
                Session["Isloggedin"] = true;
                return RedirectToAction("Index", "Student");
            }
            return RedirectToAction("Index", "Student");
        }
    }
}