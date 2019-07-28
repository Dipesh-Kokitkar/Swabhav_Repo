using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.BusinessModel
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual double MobileNumber { get; set; }
        public virtual string Email { get; set; }

        public virtual IList<UserTask> Tasks { get; set; }

        public User() {
            Tasks = new List<UserTask>();
        }
    }
}
