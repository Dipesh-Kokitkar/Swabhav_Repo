using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
            try
            {
                connection.Open();
                var command = new SqlCommand("select * from emp", connection);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Name\tSalary\n");
                while (reader.Read()) {
                    
                    Console.WriteLine(reader["ENAME"]+"\t"+reader["SAL"]);
                }
                reader.Close();
            }
            catch
            {
                Console.WriteLine("Error occoured");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
                
            }
        }
    }
}
