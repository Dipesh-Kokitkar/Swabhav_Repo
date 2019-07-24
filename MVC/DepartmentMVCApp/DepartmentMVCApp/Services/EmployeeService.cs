using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.Repositry;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Services
{
    public class EmployeeService
    {
        private DepartmentRepositry _repositry;

        public EmployeeService() {
            _repositry = new DepartmentRepositry();
        }

        public Employee ConvertVMToEmp(string name,string salary,string comission,string joindate) {
            Employee employee = new Employee();
            employee.EName = name;
            employee.Salary = Convert.ToDouble(salary);
            employee.Comission= Convert.ToDouble(comission);
            employee.DateOfJoin = joindate;

            return employee;
        }

        public Department GetDepartmentById(Guid id) {
            return _repositry.GetDepartmentById(id);
        }

        public Department GetDepartmentByName(string name) {
            return _repositry.GetDepartmentbyName(name);
        }

        public int Count(Department dept) {
            return dept.Employees.Count();
        }

        public List<Employee> GetEmployeeList(Department dept) {
            return dept.Employees;
        }

        public int GetTotalEmployeeCount() {
            return _repositry.GetTotalEmployeeCount();
        }

        public List<Employee> GetAllEmployees() {
            return _repositry.GetAllEmployees();
        }

        public void AddNewEmployee(Employee emp,Department dept) {
            emp.Department = dept;
            dept.Employees.Add(emp);
            _repositry.SaveChanges();
        }
        public string[] DepartmentNames() {
            return _repositry.GetDepartmentNames();
        }

        public Employee GetEmpById(Guid id) {
            return _repositry.GetEmployeeById(id);
        }

        public Guid EditEmployeeData(Guid id,Employee update) {
            return _repositry.EditEmployeeDetails(id,update);
        }

    }
}