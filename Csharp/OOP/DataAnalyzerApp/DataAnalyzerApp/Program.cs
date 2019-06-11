using System;
using System.Collections.Generic;
using System.Linq;
using DataAnalyzerApp.DataLoader;

namespace DataAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMain();
            //DataparsarTest();
           // WeblinkTest();

        }

        private static void WeblinkTest() {
            WebLoader webload = new WebLoader();
            string[] lines = webload.load();
            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }

        private static void DataparsarTest()
        {
            DataParsar dataparsar = new DataParsar();
            HashSet<Employee> list = dataparsar.ParseData();
            foreach (Employee emp in list)
                Display(emp);
        }

        private static void MyMain()
        {
            DataAnlayzer dataanlayzer = new DataAnlayzer();

            Console.WriteLine("Maximum salary Employee:");
            Display(dataanlayzer.GetHighestSalary());
            Console.WriteLine("\nDepartments\tCount");
            ShowTotalCount(dataanlayzer.GetDepartmentWiseCount());
            Console.WriteLine("\nDesigntion\tCount");
            ShowTotalCount(dataanlayzer.GetDesignationwiseCount());
        }

        static void ShowTotalCount(Dictionary<string,int> dictionary) {
            foreach (KeyValuePair<string, int> item in dictionary) {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
        }

        static void Display(Employee employee) {
            Console.WriteLine(employee.EmployeeID+" "+employee.Name+" "+employee.Designation+" "+employee.ManagerID+
                " "+employee.Salary);

        }
    }
}
