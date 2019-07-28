using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.Core.DatabaseMapping
{
    public class UserSubTaskMapping:ClassMap<UserSubTask>
    {
        public UserSubTaskMapping() {
            Id(usersubtask => usersubtask.Id);
            Map(usersubtask => usersubtask.SubTaskName);
            Map(usersubtask => usersubtask.SubTaskDescription);
            References(usersubtask => usersubtask.UserTask);
            Table("USERSUBTASK");
        }
    }
}
