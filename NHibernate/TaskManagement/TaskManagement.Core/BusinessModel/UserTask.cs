using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.BusinessModel
{
    public class UserTask:Entity
    {
        //public virtual int Id { get; set; }
        public virtual string TaskName { get; set; }
        public virtual string TaskDiscription { get; set; }
        public virtual DateTime TaskCreationDate { get; set; }
        public virtual DateTime TaskDeadline { get; set; }

        public virtual User User { get; set; }

        public virtual IList<UserSubTask> UserSubTasks { get; set; }

        public UserTask() {
            UserSubTasks = new List<UserSubTask>();
        }
    }
}
