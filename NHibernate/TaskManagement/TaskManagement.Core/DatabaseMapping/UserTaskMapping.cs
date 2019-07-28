using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.Core.DatabaseMapping
{
    public class UserTaskMapping:ClassMap<UserTask>
    {
        public UserTaskMapping() {
            Id(usertask => usertask.Id);
            Map(usertask => usertask.TaskName);
            Map(usertask => usertask.TaskDiscription);
            Map(usertask => usertask.TaskCreationDate);
            Map(usertask => usertask.TaskDeadline);

            References(usertask => usertask.User);

            HasMany(usertask => usertask.UserSubTasks).Cascade.All();
            Table("USERTASK");
        }
    }
}
