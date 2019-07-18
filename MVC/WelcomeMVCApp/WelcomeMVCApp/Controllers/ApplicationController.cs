using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            if (HttpContext.Application["Counter"] == null)
            {
                HttpContext.Application["Counter"] = 0;
            }
            int oldval =Convert.ToInt32(HttpContext.Application["Counter"]);
            ViewBag.oldval = oldval;
            oldval++;
            ViewBag.newval = oldval;
            HttpContext.Application["Counter"] = oldval;
            return View();
        }
    }
}