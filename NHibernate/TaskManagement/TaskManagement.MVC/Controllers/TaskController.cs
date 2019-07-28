using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagement.MVC.Models.Task;
using TaskManagement.MVC.Services;

namespace TaskManagement.MVC.Controllers
{
    public class TaskController : Controller
    {
        private TaskService _service;

        public TaskController() {
            _service = new TaskService();
        }
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add(int id) {
            AddViewModel addvm = new AddViewModel();
            addvm.Id = id;
            return View(addvm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel addvm) {
            if (ModelState.IsValid) {
                var task = _service.ConvertVMTOTask(addvm.TaskName, addvm.TaskDescription, addvm.Deadline);
                _service.AddNewTask(addvm.Id,task);
                return RedirectToAction("Home","User",new { user=_service.GetUserName(addvm.Id)});
            }
            return View(addvm);
        }

        public ActionResult Delete(int taskid,int userid) {

            _service.DeleteTask(taskid);
            return RedirectToAction("Home", "User", new { User = _service.GetUserName(userid) });
        }

        [HttpGet]
        public ActionResult Edit(int taskid,int userid) {
            var task=_service.GetTaskById(taskid);
            EditViewModel editvm = new EditViewModel();
            editvm.TaskName = task.TaskName;
            editvm.TaskDescription = task.TaskDiscription;
            editvm.Deadline =task.TaskDeadline.ToString();

            editvm.TaskId = taskid;
            editvm.UserId = userid;
            return View(editvm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editvm) {
            if (ModelState.IsValid) {
                var task = _service.ConvertVMTOTask(editvm.TaskName, editvm.TaskDescription, editvm.Deadline);
                _service.UpdateTask(editvm.TaskId, task);
                return RedirectToAction("Home", "User", new { User = _service.GetUserName(editvm.UserId) });
            }
            return View(editvm);
        }
    }
}