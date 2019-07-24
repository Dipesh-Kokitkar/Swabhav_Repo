using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Models.Deapartment
{
    public class IndexViewModel
    {
        public List<Department> DepartmentList { get; set; }
        public int Count { get; set; }

    }
}