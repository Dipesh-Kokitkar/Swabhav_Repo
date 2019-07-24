using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepartmentMVCApp.Controllers;
using System.Web.Mvc;

namespace DepartmentAppTest
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void EmployeeIndexTest()
        {
            EmployeeController employeecontroller = new EmployeeController();
            ActionResult result = employeecontroller.Index(Guid.Parse("C44830E1-92DB-41E1-ACA8-2192D4A6FC8A"));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmployeeAddTEst() {
            EmployeeController employeecontroller = new EmployeeController();
            ActionResult result = employeecontroller.Add(Guid.Parse("C44830E1-92DB-41E1-ACA8-2192D4A6FC8A"));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmployeeEditTEst() {
            EmployeeController employeecontroller = new EmployeeController();
            ActionResult result = employeecontroller.Edit(Guid.Parse("30EE79AB-DB62-42AB-8BF4-468F772D06A0"));
            Assert.IsNotNull(result);
        }
        
}
}
