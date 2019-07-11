using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
            try
            {
                connection.Open();
                Console.WriteLine("connection sucessful");
                Console.WriteLine("schema deatils:" + connection.GetSchema());
                Console.WriteLine("state:" + connection.State);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Database name:" + connection.Database);
                Console.WriteLine("timeout:" + connection.ConnectionTimeout);

                //var command = new SqlCommand(connection);
                
            }
            catch
            {
                Console.WriteLine("errored occoured");
            }
            finally {
                if (connection.State==System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
        }
    }
}
