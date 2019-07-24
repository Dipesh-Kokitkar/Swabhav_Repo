using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepartmentMVCApp.Controllers;
using System.Web.Mvc;
using System.Web;

namespace DepartmentAppTest
{
    [TestClass]
    public class DepartementControllerTest
    {
        [TestMethod]
        public void DepartmentControlIndexTest()
        {
            var departmentcontroller = new DepartmentController();
            var result = departmentcontroller.Index();
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void DepartmentControlAddTest() {
            var departmentcontroller = new DepartmentController();
            ActionResult result = departmentcontroller.Add();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DepartmentControlEditTEst() {
            var departmentcontroller = new DepartmentController();
            ActionResult result = departmentcontroller.Edit(Guid.Parse("C44830E1-92DB-41E1-ACA8-2192D4A6FC8A"));
            Assert.IsNotNull(result);
        }
    }
}
