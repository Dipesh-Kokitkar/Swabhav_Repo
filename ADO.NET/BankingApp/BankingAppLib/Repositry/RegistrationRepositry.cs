using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingAppLib.Repositry
{
    public class RegistrationRespositry
    {
        private string _name, _password;
        private double _amount;
        private SqlConnection _connection;
        private SqlTransaction _transaction;

        public RegistrationRespositry() {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["AurionProConnectionString"].ToString();
            _connection = new SqlConnection(connectionstring);
        }

        public bool RegistorNewAccount(string name,string password,double amount) {
            _name=name;
            _password = password;
            _amount = amount;

            string masterbankquery = "insert into bank_master values(@name ,@password,@amount)";
            string transactionquery = "insert into bank_transaction values(@name,@amount,'D','"+DateTime.Now+"')";

            try
            {
                _connection.Open();
                _transaction = _connection.BeginTransaction();
                SqlCommand command1 = new SqlCommand(masterbankquery, _connection, _transaction);
                command1.Parameters.Add("@name",System.Data.SqlDbType.VarChar);
                command1.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                command1.Parameters.Add("@amount", System.Data.SqlDbType.Float);
                command1.Parameters["@name"].Value = _name;
                command1.Parameters["@password"].Value = _password;
                command1.Parameters["@amount"].Value = _amount;

                SqlCommand command2 = new SqlCommand(transactionquery, _connection, _transaction);
                command2.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                command2.Parameters.Add("@amount", System.Data.SqlDbType.Float);
                command1.Parameters["@name"].Value = _name;
                command1.Parameters["@amount"].Value = _amount;

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                _transaction.Commit();
                Console.WriteLine("Commited");
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("message:" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("error:" + e.Message);
            }
            finally {
                _connection.Close();
            }
            return false;
        }
    }
}
