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

        public UserTask GetTaskById(int id) {
            return _respository.GetTaskById(id);
        }

        public List<UserSubTask> GetAllSubTask(UserTask task) {
            return _respository.GetAllSubTasks(task);
        }
    }
}