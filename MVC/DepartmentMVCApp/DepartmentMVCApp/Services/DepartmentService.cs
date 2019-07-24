using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.Repositry;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Services
{
    public class DepartmentService
    {
        private DepartmentRepositry _repositry;

        public DepartmentService() {
            _repositry = new DepartmentRepositry();
        }

        public Department GetDepartmentById(Guid id) {
            return _repositry.GetDepartmentById(id);
        }

        public List<Department> GetDepartmentList() {
            return _repositry.GetDepartmentList();
        }

        public int GetCount() {
            return _repositry.GetDepartmentCount();
        }

        public void AddNewDepartment(Department dept) {
            _repositry.AddNewDepartment(dept);

        }

        public void EditDepartmentDetails(Guid id ,Department dept) {
            _repositry.EditDepartmentDeatils(id,dept);
        }

        public Department ConvertVMToDept(string name,string loaction) {
            Department dept = new Department { Dname = name, Location = loaction };
            return dept;
        }
    }
}