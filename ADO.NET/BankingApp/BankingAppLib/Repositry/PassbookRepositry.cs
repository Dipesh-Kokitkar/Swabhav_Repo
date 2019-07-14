using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using BankingAppLib.Model;

namespace BankingAppLib.Repositry
{
    public class PassbookRepositry
    {
        private SqlConnection _connection;

        public PassbookRepositry() {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["AurionProConnectionString"].ToString();
            _connection = new SqlConnection(connectionstring);
        }

        public List<BankTransaction> GetCustomerData(string name) {
            string query = "select * from BANK_TRANSACTION where name=@name";
            List<BankTransaction> transactions = new List<BankTransaction>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@name",System.Data.SqlDbType.VarChar);
                command.Parameters["@name"].Value = name;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transactions.Add(new BankTransaction(reader["NAME"].ToString(), Convert.ToDouble(reader["AMOUNT"]),
                        reader["TYPE"].ToString(), reader["TDATE"].ToString()));
                }
                reader.Close();
                return transactions;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return null;
        }
       
    }
}
