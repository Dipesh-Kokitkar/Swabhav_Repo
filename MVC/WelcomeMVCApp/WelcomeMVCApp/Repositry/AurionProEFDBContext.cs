using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Repositry
{
    public class AurionProEFDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}