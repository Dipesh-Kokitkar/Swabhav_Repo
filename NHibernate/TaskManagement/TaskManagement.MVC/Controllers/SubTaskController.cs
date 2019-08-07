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
        private SubTaskService _service;

        public SubTaskController() {
            _service = new SubTaskService();
        }

        public ActionResult Index(Guid id)
        {
            IndexViewModel vm = new IndexViewModel();
            vm.TaskId = id.ToString();
            var task=_service.GetTaskById(id);
            vm.TaskName = task.TaskName;
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add(Guid id) {
            AddViewModel addvm = new AddViewModel();
            addvm.TaskId = id.ToString();
            return View(addvm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel addvm) {
            if (ModelState.IsValid) {
                var subtask = _service.ConvertVMToSubtask(addvm.SubTaskName,addvm.SubTaskDescription);
                _service.AddSubTask(Guid.Parse(addvm.TaskId),subtask);
                return RedirectToAction("Index","SubTask",new { Id=addvm.TaskId});
            }
            return View(addvm);
        }

        [HttpGet]
        public ActionResult Edit(Guid subtaskid,Guid taskid) {
            EditViewModel editvm = new EditViewModel();
            editvm.TaskId = taskid.ToString();
            editvm.SubtaskId = subtaskid.ToString();
            var subtask = _service.GetSubTaskById(subtaskid);
            editvm.SubTaskName = subtask.SubTaskName;
            editvm.SubTaskDescription = subtask.SubTaskDescription;
            return View(editvm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editvm) {
            if (ModelState.IsValid) {
                _service.EditSubTask(Guid.Parse(editvm.SubtaskId),
                    _service.ConvertVMToSubtask(editvm.SubTaskName, editvm.SubTaskDescription));
                return RedirectToAction("Index","SubTask",new { Id=editvm.TaskId});
            }
            return View(editvm);
        }

        public ActionResult Delete(Guid subtaskid,Guid taskid) {
            _service.DeleteSubTask(subtaskid);
            return RedirectToAction("Index","SubTask",new { Id=taskid});
        }
    }
}