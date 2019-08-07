using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.MVC.Models.Task
{
    public class EditViewModel
    {
        [Required(ErrorMessage ="This can not be empty")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "This can not be empty")]
        public string TaskDescription { get; set; }
        [Required(ErrorMessage = "This can not be empty")]
        public string Deadline { get; set; }

        public string TaskId { get; set; }
        public string UserId { get; set; }
    }
}