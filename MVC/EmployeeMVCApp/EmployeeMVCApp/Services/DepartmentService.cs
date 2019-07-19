using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeMVCApp.BusinessModel;
using System.IO;

namespace EmployeeMVCApp.Services
{
    public class DepartmentService
    {
        private List<Employee> _filterlist;
        private List<Department> _departments;
        public DepartmentService()
        {
            _filterlist = new List<Employee>();
            _departments = new List<Department>();
            _departments.Add(new Department { DepartmentId = 10, DepartmentName = "ACCOUNTING" });
            _departments.Add(new Department { DepartmentId = 20, DepartmentName = "RESEARCH" });
            _departments.Add(new Department { DepartmentId = 30, DepartmentName = "SALES" });
            _departments.Add(new Department { DepartmentId = 40, DepartmentName = "OPERATIONS" });
        }


        public int GetIdByName(string name) {
            foreach (Department dept in _departments) {
                if (dept.DepartmentName.Equals(name)) {
                    return dept.DepartmentId;
                }
            }
            return 0;
        }

        public List<Employee> GetEmployeeByDeptno(int deptno)
        {
            foreach (Employee emp in LoadEmployeeData())
            {
                if (Convert.ToInt32(emp.DeptNo) == deptno)
                {
                    _filterlist.Add(emp);
                }
            }
            return _filterlist;
        }


        public List<Employee> LoadEmployeeData()
        {
            List<Employee> empdata = new List<Employee>();
            string PATH = @"D:\Swabhav Respositry\Csharp\EmployeeIEnumarable\EmployeeIEnumarable\bin\Debug\emp.txt";
            if (File.Exists(PATH))
            {
                string[] datalines = File.ReadAllLines(PATH);
                foreach (string line in datalines)
                {
                    //Console.WriteLine(line);
                    string[] attributes = line.Split(',');
                    //foreach (string a in attributes) { Console.WriteLine(a); }
                    empdata.Add(new Employee
                    {
                        Empno = attributes[0],
                        Ename = attributes[1],
                        Job = attributes[2],
                        MGR = attributes[3],
                        Hiredate = attributes[4],
                        Salary = attributes[5],
                        Commission = attributes[6],
                        DeptNo = attributes[7]
                    });
                }
            }
            return empdata;
        }
    }
}