using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Repositry
{
    public class DepartmentRepositry : IDepartmentRepositry
    {
        private AurionProEFDBContext _context;

        public DepartmentRepositry()
        {
            _context = new AurionProEFDBContext();
        }

        public void SaveChanges() {
            _context.SaveChanges();
        }

        public Department GetDepartmentbyName(string name) {
            Department dept = null;
           var query= _context.Departments.Where((dept1) => dept1.Dname.Equals(name));

            foreach (var department in query) {
                dept = department;
            }

            // return _context.Departments.Find(name);
            return dept;
        }

        public Department GetDepartmentById(Guid id) {
            return _context.Departments.Find(id);
        }

        public List<Department> GetDepartmentList()
        {
            return _context.Departments.ToList();
        }
        public void AddNewDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public string[] GetDepartmentNames()
        {
            return _context.Departments.Select((dept) => dept.Dname).ToArray();
        }

        public int GetDepartmentCount()
        {
            return _context.Departments.Count();
        }

        public void DeleteDepartment() {

        }

        public void EditDepartmentDeatils(Guid id,Department updated) {
            Department dept = _context.Departments.Find(id);
            //var query=
            dept.Dname = updated.Dname;
            dept.Location = updated.Location;
            _context.SaveChanges();
        }

        public Employee GetEmployeeById(Guid id) {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetAllEmployees(int num) {
            if (num == 0) {
                return _context.Employees.OrderBy((emp) => emp.EName).Take(2).ToList();
            }
           return _context.Employees.OrderBy((emp)=>emp.EName).Skip(num).Take(2).ToList();
           // return _context.Employees.ToList();

        }

        public List<Employee> SearchEmployee(string name) {
            List<Employee> SearchResult = new List<Employee>();
            foreach (Employee emp in _context.Employees) {
                if (emp.EName.Equals(name)) {
                    SearchResult.Add(emp);
                }
            }
            return SearchResult;
        }

        public int GetTotalEmployeeCount() {
            return _context.Employees.Count();
        }

        public Guid EditEmployeeDetails(Guid id,Employee updated) {
            Employee emp = GetEmployeeById(id);
            emp.EName = updated.EName;
            emp.Salary = updated.Salary;
            emp.Comission = updated.Comission;
            emp.DateOfJoin = updated.DateOfJoin;
            _context.SaveChanges();
            return emp.Department.ID;
        }
    }
}