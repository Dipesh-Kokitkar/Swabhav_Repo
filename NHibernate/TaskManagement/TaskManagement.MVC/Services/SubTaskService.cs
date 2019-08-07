using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagement.Core.Repository;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.MVC.Services
{
    public class SubTaskService
    {
        private TaskRespository _respository;
        public SubTaskService() {
            _respository = new TaskRespository();
        }

        public UserTask GetTaskById(Guid id) {
            return _respository.GetTaskById(id);
        }

        public UserSubTask GetSubTaskById(Guid id) {
            return _respository.GetSubTaskById(id);
        }

        public List<UserSubTask> GetAllSubTask(UserTask task) {
            return _respository.GetAllSubTasks(task);
        }

        public void AddSubTask(Guid id,UserSubTask subtask) {
            _respository.AddNewSubTask(id, subtask);
        }

        public void EditSubTask(Guid id,UserSubTask updated) {
            _respository.UpdateSubTask(id,updated);
        }

        public void DeleteSubTask(Guid id) {
            _respository.DeleteSubTask(id);
        }

        public UserSubTask ConvertVMToSubtask(string name,string description) {
            return new UserSubTask { SubTaskName = name, SubTaskDescription = description };
        }
    }
} 