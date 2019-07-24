using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityApp.BusinessModel
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float CGPA { get; set; }
        public string Loaction { get; set; }
    }
}
