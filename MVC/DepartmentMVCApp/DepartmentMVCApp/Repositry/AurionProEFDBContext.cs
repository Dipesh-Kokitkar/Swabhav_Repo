using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Repositry
{
    public class AurionProEFDBContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}