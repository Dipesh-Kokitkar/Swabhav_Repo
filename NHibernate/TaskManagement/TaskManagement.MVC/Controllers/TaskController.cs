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
        public ActionResult Add(Guid id) {
            AddViewModel addvm = new AddViewModel();
            addvm.Id = id.ToString();
            return View(addvm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel addvm) {
            if (ModelState.IsValid) {
                var task = _service.ConvertVMTOTask(addvm.TaskName, addvm.TaskDescription, addvm.Deadline);
                _service.AddNewTask(Guid.Parse(addvm.Id),task);
                return RedirectToAction("Home","User",new { user=_service.GetUserName(Guid.Parse(addvm.Id)) });
            }
            return View(addvm);
        }

        public ActionResult Delete(Guid taskid,Guid userid) {

            _service.DeleteTask(taskid);
            return RedirectToAction("Home", "User", new { User = _service.GetUserName(userid) });
        }

        [HttpGet]
        public ActionResult Edit(Guid taskid,Guid userid) {
            var task=_service.GetTaskById(taskid);
            EditViewModel editvm = new EditViewModel();
            editvm.TaskName = task.TaskName;
            editvm.TaskDescription = task.TaskDiscription;
            editvm.Deadline =task.TaskDeadline.ToString();

            editvm.TaskId = taskid.ToString();
            editvm.UserId = userid.ToString();
            return View(editvm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editvm) {
            if (ModelState.IsValid) {
                var task = _service.ConvertVMTOTask(editvm.TaskName, editvm.TaskDescription, editvm.Deadline);
                _service.UpdateTask(Guid.Parse(editvm.TaskId), task);
                return RedirectToAction("Home", "User", new { User = _service.GetUserName(Guid.Parse(editvm.TaskId)) });
            }
            return View(editvm);
        }
    }
}