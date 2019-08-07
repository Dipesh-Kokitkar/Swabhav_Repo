using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagement.Core.Repository;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.MVC.Services
{
    public class TaskService
    {
        private TaskRespository _respository;

        public TaskService() {
            _respository = new TaskRespository();
        }

        public string GetUserName(Guid id) {
            return _respository.GetUsername(id);
        }

        public UserTask GetTaskById(Guid id) {
            return _respository.GetTaskById(id);
        }

        public void AddNewTask(Guid id,UserTask task) {
            _respository.AddNewTask(id,task);
        }

        public List<UserSubTask> GetSubTask(UserTask task) {
           return _respository.GetAllSubTasks(task);
        }

        public UserTask ConvertVMTOTask(string name,string description,string date) {
            UserTask task = new UserTask
            {
                TaskName = name,
                TaskDiscription = description,
                TaskCreationDate = DateTime.Now,
                TaskDeadline = DateTime.Parse(date)
            };
            return task;
        }

        public List<UserTask> GetAllUserTasks(User user) {
            return _respository.GetAllTasks(user);
        }

        public List<UserSubTask> GetAllUserTasks(UserTask task)
        {
            return _respository.GetAllSubTasks(task);
        }

        public void UpdateTask(Guid id,UserTask updated) {
            _respository.UpdateTask(id,updated);
        }

        public void DeleteTask(Guid id) {
            _respository.DeleteTask(id);
        }
    }
}