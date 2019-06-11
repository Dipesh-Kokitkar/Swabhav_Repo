using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAnalyzerApp
{
    class DataAnlayzer
    {
        private readonly HashSet<Employee> _employeelist;
        private readonly DataParsar _dataparsar;

        public DataAnlayzer()
        {
            _dataparsar = new DataParsar();
            _employeelist = _dataparsar.ParseData();
        }

        public Employee GetHighestSalary()
        {
            double highestsalary = 0;
            Employee highsalaryemployee = null;

            foreach (Employee employee in _employeelist)
            {
                if (highestsalary < Convert.ToDouble(employee.Salary))
                {
                    highestsalary = Convert.ToDouble(employee.Salary);
                    highsalaryemployee = employee;
                }
            }
            return highsalaryemployee;
        }

        public Dictionary<string, int> GetDepartmentWiseCount()
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (Employee employee in _employeelist)
            {
                if (count.ContainsKey(employee.DepartmentNumber))
                {
                    int value = 0;
                    count.TryGetValue(employee.DepartmentNumber, out value);
                    count[employee.DepartmentNumber] = value + 1;
                }
                else
                {
                    count.Add(employee.DepartmentNumber, 1);
                }
            }
            return count;
        }

        public Dictionary<string, int> GetDesignationwiseCount()
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (Employee employee in _employeelist)
            {
                if (count.ContainsKey(employee.Designation))
                {
                    int value = 0;
                    count.TryGetValue(employee.Designation, out value);
                    count[employee.Designation] = value + 1;
                }
                else
                {
                    count.Add(employee.Designation, 1);
                }
            }
            return count;
        }
    }
}
