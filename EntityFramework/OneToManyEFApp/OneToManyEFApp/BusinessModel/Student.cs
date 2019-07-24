using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp.BusinessModel
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        public int Rollno { set; get; }
        public string Name { set; get; }
        public double CGPA { set; get; }
        
        public virtual Department Department { set; get; }
    }
}
