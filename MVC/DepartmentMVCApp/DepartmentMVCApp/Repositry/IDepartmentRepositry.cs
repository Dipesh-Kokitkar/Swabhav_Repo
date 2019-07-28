using System;
using System.Collections.Generic;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Repositry
{
    public interface IDepartmentRepositry
    {
        void AddNewDepartment(Department department);
        void DeleteDepartment();
        void EditDepartmentDeatils(Guid id, Department updated);
        Guid EditEmployeeDetails(Guid id, Employee updated);
        List<Employee> GetAllEmployees(int num);
        Department GetDepartmentById(Guid id);
        Department GetDepartmentbyName(string name);
        int GetDepartmentCount();
        List<Department> GetDepartmentList();
        string[] GetDepartmentNames();
        Employee GetEmployeeById(Guid id);
        int GetTotalEmployeeCount();
        void SaveChanges();
        List<Employee> SearchEmployee(string name);
    }
}