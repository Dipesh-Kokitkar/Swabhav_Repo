using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp2.BusinessModel
{
    [Table("PRODUCT")]
    public class Product:Entity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public float Discount { get; set; }
    }
}
