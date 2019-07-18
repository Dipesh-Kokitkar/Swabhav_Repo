using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.Registration;

namespace WelcomeMVCApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration

        public ActionResult Index() {
            IndexViewModel vm = new IndexViewModel();
            return View(vm);
        }


        [HttpPost]
        public ActionResult Index(IndexViewModel vm)
        {
            if (!ModelState.IsValid) {
                return View(vm);
            }

            vm.SucessMessage = "Registeration Sucessful!"+"\nName:"+vm.Name+"\nAge:"+vm.Age+
                "\nSalary:"+vm.Salary+"\nEmail:"+vm.Email;
            return View(vm);
        }

        
    }
}