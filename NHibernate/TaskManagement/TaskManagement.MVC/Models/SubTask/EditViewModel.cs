using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagement.MVC.Models.SubTask
{
    public class EditViewModel
    {
        [Required(ErrorMessage = "This can not be empty")]
        public string SubTaskName { get; set; }
        [Required(ErrorMessage = "This can not be empty")]
        public string SubTaskDescription { get; set; }

        public string TaskId { get; set; }
        public string SubtaskId { get; set; }
    }
}