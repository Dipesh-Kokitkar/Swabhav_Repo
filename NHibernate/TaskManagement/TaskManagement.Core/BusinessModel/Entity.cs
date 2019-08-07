using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.BusinessModel
{
    public class Entity
    {
        public virtual Guid Id { get; set; }

        public Entity() {
            Id = Guid.NewGuid();
        }
    }
    
}
