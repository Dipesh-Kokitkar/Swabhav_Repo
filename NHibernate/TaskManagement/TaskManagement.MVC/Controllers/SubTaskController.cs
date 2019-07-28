using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagement.MVC.Models.SubTask;
using TaskManagement.MVC.Services;

namespace TaskManagement.MVC.Controllers
{
    public class SubTaskController : Controller
    {
        // GET: SubTask
        public ActionResult Index(int id,string name)
        {
            IndexViewModel vm = new IndexViewModel();
            vm.TaskId = id;
            vm.TaskName = name;
            return View(vm);
        }
    }
}