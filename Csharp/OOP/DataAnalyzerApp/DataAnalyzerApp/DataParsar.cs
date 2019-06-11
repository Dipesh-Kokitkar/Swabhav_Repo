using System;
using System.Collections.Generic;
using DataAnalyzerApp.DataLoader;
using System.Text;

namespace DataAnalyzerApp
{
    class DataParsar
    {
        private HashSet<Employee> employeedetatils;
        private DiskLoader diskloader;
        EqualityCheck _check;

        public DataParsar()
        {
            _check = new EqualityCheck();
            employeedetatils = new HashSet<Employee>(_check);
            diskloader = new DiskLoader();
        }

        public HashSet<Employee> ParseData()
        {
            string[] lines = diskloader.load();
            foreach (string line in lines)
            {
                string[] attributes = line.Split(',');
                employeedetatils.Add(new Employee(attributes));
            }
            return employeedetatils;
        }
    }
}
