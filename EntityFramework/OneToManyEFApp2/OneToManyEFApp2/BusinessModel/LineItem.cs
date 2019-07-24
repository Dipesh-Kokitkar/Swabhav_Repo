using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp2.BusinessModel
{
    [Table("LINEITEM")]
    public class LineItem:Entity
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        //public double Unitprice {get;set;}
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
