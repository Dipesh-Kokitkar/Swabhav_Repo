using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.BusinessModel
{
    public class UserSubTask:Entity
    {
        //public virtual int Id { get; set; }
        public virtual string SubTaskName { get; set; }
        public virtual string SubTaskDescription{ get; set; }

        public virtual UserTask UserTask { get; set; }
    }
}
