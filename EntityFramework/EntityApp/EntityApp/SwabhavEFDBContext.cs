using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityApp.BusinessModel;

namespace EntityApp
{
    class SwabhavEFDBContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
    }
}
