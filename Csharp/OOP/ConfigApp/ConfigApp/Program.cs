using System;
using System.Configuration;

namespace ConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = ConfigurationSettings.AppSettings["server"].ToString();
            string port = ConfigurationSettings.AppSettings["port"].ToString();
            string username = ConfigurationSettings.AppSettings["username"].ToString();
            string password = ConfigurationSettings.AppSettings["password"].ToString();
            string database = ConfigurationSettings.AppSettings["database"].ToString();

            Console.WriteLine("Server:"+server+"\nPort:"+port+"\nUsername:"+username+"\nPassword:"+password+"\nDatabase:"+database);
        }
    }
}
