using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.MVC.Models.SubTask
{
    public class IndexViewModel
    {
        public string TaskName { get; set; }
        public string TaskId { get; set; }
        public List<UserSubTask> SubtaskList { set; get; }
    }
}