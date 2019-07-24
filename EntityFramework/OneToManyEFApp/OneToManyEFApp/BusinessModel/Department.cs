using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEFApp.BusinessModel
{
    [Table("DEPARTMENT")]
    public class Department
    {
        [Key]
        public int Deptno { set; get; }
        public string Dname { set; get; }

        public virtual List<Student> Students { get; set; }

        public Department() {
            Students = new List<Student>();
        }

    }
}
