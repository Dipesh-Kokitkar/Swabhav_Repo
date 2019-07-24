using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GobalizationApp.Models.Home;

namespace GobalizationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IndexModelView vm = new IndexModelView();
            if (string.IsNullOrEmpty(vm.selectedLanguge)) {
                vm.Text = Resouces.Resource.Lang;
            }
            if (vm.selectedLanguge.Equals("English")) {
                vm.Text = Resouces.Resource.Lang;
            }
            if (vm.selectedLanguge.Equals("Marathi")){
                vm.Text = Resouces.Resource_MR.Lang;
            }
            return View(vm);
        }
    }
}