using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            if (Session["Counter"] == null)
            {
                Session["Counter"] = 0;
            }
            int olddata =Convert.ToInt32(Session["Counter"]);
            ViewBag.olddata = olddata;
            olddata++;
            Session["Counter"] = olddata;
            ViewBag.Newval = olddata;
            ViewBag.id = Session.SessionID;
            return View();
                    }
    }
}