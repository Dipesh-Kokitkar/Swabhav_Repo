using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingAppLib.Repositry
{
    public class Main
    {
        private string _currentuser;
        private SqlConnection _connection;
        public Main(string name) {
            _currentuser = name;
            _connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
        }

        public string GetCurrentUser() {
            string qurey = "select * from bank_master where name=@currentuser";
            try
            {
                _connection.Open();
                var command = new SqlCommand(qurey, _connection);
                command.Parameters.Add("@currentuser", System.Data.SqlDbType.VarChar);
                command.Parameters["@currentuser"].Value = _currentuser;
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string balance = reader["BALANCE"].ToString();
                reader.Close();
                return balance;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally {
                _connection.Close();
            }
            //return null;
        }
    }
}
