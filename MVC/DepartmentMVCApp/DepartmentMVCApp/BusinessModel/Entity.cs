using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.BusinessModel
{
    public class Entity
    {
        public Guid ID { get; set; }

        public Entity() {
            ID = Guid.NewGuid();
        }
    }
}