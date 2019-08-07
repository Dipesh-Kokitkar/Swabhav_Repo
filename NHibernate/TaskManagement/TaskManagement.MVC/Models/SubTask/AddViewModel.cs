using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.MVC.Models.SubTask
{
    public class AddViewModel
    {
        [Required(ErrorMessage ="This can not be empty")]
        public string SubTaskName { get; set; }
        [Required(ErrorMessage = "This can not be empty")]
        public string SubTaskDescription { get; set; }

        public string TaskId { get; set; }
    }
}