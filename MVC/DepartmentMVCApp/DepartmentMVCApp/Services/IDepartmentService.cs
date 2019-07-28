using System;
using System.Collections.Generic;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Services
{
    public interface IDepartmentService
    {
        void AddNewDepartment(Department dept);
        Department ConvertVMToDept(string name, string loaction);
        void EditDepartmentDetails(Guid id, Department dept);
        int GetCount();
        Department GetDepartmentById(Guid id);
        List<Department> GetDepartmentList();
    }
}