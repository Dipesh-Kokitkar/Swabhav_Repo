using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       public string Test() {
            return "<h1>Welcome to Test </h1>";
        }

        public ContentResult Content() {
            return Content("<h1>Returning some string from content</h1>");
        }
        public ViewResult Index(string devloper) {
            //var student = new Student { Name = "Abc", CGPA = 9.5, Location = "Mumbai" };

            ViewBag.Message = devloper;
            return View();
        }
    }
}