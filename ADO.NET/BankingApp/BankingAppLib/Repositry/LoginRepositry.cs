using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingAppLib.Repositry
{
    public class LoginRespositry
    {
        private SqlConnection _connection;
        //private SqlTransaction _transaction;

        public LoginRespositry() {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["AurionProConnectionString"].ToString();
            _connection = new SqlConnection(connectionstring);
        }

        public bool ValidateUser(string name,string pwd) {
            string userquery = "select * from bank_master";
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(userquery, _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (name.Equals(reader["NAME"]) && pwd.Equals(reader["PWD"]))
                    {
                        return true;
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("message:" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                _connection.Close();
            }
            return false;
        }
    }
}
