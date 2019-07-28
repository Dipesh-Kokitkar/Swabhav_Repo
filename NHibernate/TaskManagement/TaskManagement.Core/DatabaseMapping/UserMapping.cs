using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.Core.DatabaseMapping
{
    public class UserMapping:ClassMap<User>
    {
        public UserMapping() {
            Id(user => user.Id);
            Map(user => user.Username);
            Map(user => user.Password);
            Map(user => user.MobileNumber);
            Map(user => user.Email);

            HasMany(user => user.Tasks).Cascade.All();
            //Table("USER");
        }
    }
}
