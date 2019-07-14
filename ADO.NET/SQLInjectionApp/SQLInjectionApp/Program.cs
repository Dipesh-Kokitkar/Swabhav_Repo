using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SQLInjectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
            Console.WriteLine("Enter Department Number:");
            string deptno = Console.ReadLine();
            try
            {
                connection.Open();
                var command = new SqlCommand("select * from dept where deptno=" + deptno,connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows==true)
                {
                    Console.WriteLine("ID\tName\tLocation");
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2));
                    }
                }
                else
                {
                    Console.WriteLine("No records found!");
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error"+e.Message);
            }
            finally {
                connection.Close();
            }
        }
    }
}
