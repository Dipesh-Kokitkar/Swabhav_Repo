using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeeIEnumarable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empdata = Load();
            //case1();
            //case2();
            case13(empdata);
        }

        static void case1() {
            List<Employee> empdata = Load();
            IEnumerable<Employee> empwithenameorder = empdata.OrderBy((employee) => employee.Ename);
            DisplayData(empwithenameorder);
        }

        static void case2() {
            List<Employee> empdata = Load();
            IEnumerable<Employee> empwithsalbetween = empdata
                .Where((employee) => Convert.ToInt32(employee.Salary)>2000 && Convert.ToInt32(employee.Salary)<=5000 );
            DisplayData(empwithsalbetween);
        }

        static void case3( List<Employee> empdata) {
            IEnumerable<Employee> empwithdept10 = empdata
                .Where((employee) => employee.DeptNo == "10");
            DisplayData(empwithdept10);
        }

        static void case4(List<Employee> empdata)
        {
            IEnumerable<Employee> empwithdept10or20 = empdata
                .Where((employee) => employee.DeptNo == "10" || employee.DeptNo=="20");
            DisplayData(empwithdept10or20);
        }

        static void case5(List<Employee> empdata)
        {
            IEnumerable<Employee> empwithjob = empdata
                .Where((employee) => employee.Job== "MANAGER");
            DisplayData(empwithjob);
        }

        static void case6(List<Employee> empdata)
        {
            IEnumerable<Employee> empwithdeptandjob = empdata
                .Where((employee) => employee.Job == "MANAGER" && employee.DeptNo == "10");
            DisplayData(empwithdeptandjob);
        }

        static void case7(List<Employee> empdata)
        {
            IEnumerable<Employee> empwithcommnull = empdata
                .Where((employee) => employee.Commissin=="NULL");
            DisplayData(empwithcommnull);
        }

        static void case8(List<Employee> empdata)
        {
            var empwithctc = empdata
                .Select((employee)=>new { employee.Ename,employee.Salary,CTC=Convert.ToInt32(employee.Salary)*12});
            foreach (var emp in empwithctc) {
                Console.WriteLine(emp.Ename+"\t"+emp.Salary+"\t"+emp.CTC);
            }
            //DisplayData(empwithdeptandjob);
        }

        static void case9(List<Employee> empdata)
        {
            var empwithlower = empdata
                .Select((employee)=>new { Name=employee.Ename.ToLower() });
            //DisplayData(empwithdeptandjob);
            foreach (var emp in empwithlower)
            {
                Console.WriteLine(emp.Name);
            }
        }

        static void case10(List<Employee> empdata)
        {
            var empwithudept = empdata
                .Select((employee)=>new {employee.DeptNo }).Distinct();
            //DisplayData(empwithdeptandjob);
            foreach (var emp in empwithudept)
            {
                Console.WriteLine(emp.DeptNo);
            }
        }
        static void case11(List<Employee> empdata)
        {
            var empwithexperiance = empdata
                .Select((employee) => new { employee.Ename,employee.Hiredate,Experinace= DateTime.Now.Year-DateTime.Parse(employee.Hiredate).Year });
            //DisplayData(empwithdeptandjob);
            foreach (var emp in empwithexperiance)
            {
                Console.WriteLine(emp.Ename+"\t"+emp.Hiredate+"\t"+emp.Experinace);
            }
        }

        static void case12(List<Employee> empdata)
        {
            var empwithtopsalary = empdata
                .OrderByDescending((employee) => Convert.ToInt32(employee.Salary)).Take(3);
            DisplayData(empwithtopsalary);
           
        }

        static void case13(List<Employee> empdata)
        {
            var num="";
            var dept = empdata
                .Where((employee) => employee.Ename == "SCOTT").Select((employee) => employee.DeptNo);
            foreach (var d in dept) {
                num = d;
            }
            Console.WriteLine(num);
            var empwithdept = empdata.Where((employee) => employee.DeptNo == num);
            DisplayData(empwithdept);
        }

        static void case14(List<Employee> empdata)
        {
            var job = "";
            var empjob = empdata
                .Where((employee) => employee.Ename == "BLAKE").Select((employee) => employee.Job);
            foreach (var d in empjob)
            {
                job = d;
            }
            //Console.WriteLine(num);
            var empwithjob = empdata.Where((employee) => employee.Job==job);
            DisplayData(empwithjob);
        }

        static void case15(List<Employee> empdata)
        {
            var job = "";
            var empjob = empdata
                .Where((employee) => employee.Ename == "BLAKE").Select((employee) => employee.Job);
            foreach (var d in empjob)
            {
                job = d;
            }
            //Console.WriteLine(num);
            var empwithjob = empdata.Where((employee) => employee.Job == job);
            DisplayData(empwithjob);
        }


        static void DisplayData(IEnumerable<Employee> ienumrabledata) {
            foreach (Employee employee in ienumrabledata) {
                Console.WriteLine(employee.Empno+"\t"+employee.Ename+"\t"+employee.Job+"\t"+
                    employee.Hiredate+"\t"+employee.Salary+"\t"+employee.Commissin+"\t"+employee.DeptNo);
            }
        }

        static List<Employee> Load() {
            List<Employee> empdata=new List<Employee>();
             string PATH = @"emp.txt";
            if(File.Exists(PATH))
            {
                string[] datalines = File.ReadAllLines(PATH);
                foreach (string line in datalines)
                {
                    //Console.WriteLine(line);
                    string[] attributes = line.Split(',');
                    //foreach (string a in attributes) { Console.WriteLine(a); }
                    empdata.Add(new Employee {
                        Empno =attributes[0],
                        Ename=attributes[1],
                        Job=attributes[2],
                        MGR= attributes[3],
                        Hiredate = attributes[4],
                        Salary= attributes[5],
                        Commissin= attributes[6],
                        DeptNo= attributes[7]
                    });
                }
                //return empdata;
            }
            return empdata;
        } 
    }
}
