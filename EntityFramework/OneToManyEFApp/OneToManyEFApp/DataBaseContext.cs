using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OneToManyEFApp.BusinessModel;

namespace OneToManyEFApp
{
    class DataBaseContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departemnts { set; get; }
    }
}
