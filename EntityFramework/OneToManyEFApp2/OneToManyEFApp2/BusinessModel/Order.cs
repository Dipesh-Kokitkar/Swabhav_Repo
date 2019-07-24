using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp2.BusinessModel
{
    [Table("ORDER")]
    public class Order:Entity
    {
        //public string CustomerName { get; set; }
        public string Date { get; set; }
        public virtual List<LineItem> LineItems { get; set; }
        public virtual Customer Customer { get; set; }

        public Order() {
            LineItems = new List<LineItem>();
        }
    }
}
