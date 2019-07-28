using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.MVC.Models.User
{
    public class HomeViewModel
    {
        public string CurrentUser { get; set; }
        public int UserId { get; set; }
        public List<UserTask> UserTaskList { get; set; }
    }
}