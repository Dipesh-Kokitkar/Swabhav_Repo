using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp2.BusinessModel
{
    [Table("CUSTOMER")]
    public class Customer:Entity
    {
        public string Name { get; set; }
        public double PhoneNumber { get; set; }
        public string Location { get; set; }
        public virtual List<Order> Orders { get; set; }

        public Customer() {
            Orders = new List<Order>();
        }
    }
}
