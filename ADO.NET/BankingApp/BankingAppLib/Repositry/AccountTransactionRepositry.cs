using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingAppLib.Repositry
{
    public class AccountTransactionRespositry
    {
        private SqlConnection _connection;

        public AccountTransactionRespositry() {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["AurionProConnectionString"].ToString();
            _connection = new SqlConnection(connectionstring);
        }

        public bool Withdraw(string name,double amount) {
            SqlTransaction transaction=null;
            string querymaster = "update BANK_MASTER set balance=balance-@amount where name='@name'";
            string querytransaction= "insert into BANK_TRANSACTION values('@name',@amount,'W','"+DateTime.Now+"')";
            try
            {
                _connection.Open();
                transaction = _connection.BeginTransaction();
                var command1 = new SqlCommand(querymaster, _connection, transaction);
                command1.Parameters.Add("@amount", System.Data.SqlDbType.Float);
                command1.Parameters.Add("@name",System.Data.SqlDbType.VarChar);
                command1.Parameters["@amount"].Value = amount;
                command1.Parameters["@name"].Value = name;
                var command2 = new SqlCommand(querytransaction, _connection, transaction);
                command2.Parameters.Add("@amount", System.Data.SqlDbType.Float);
                command2.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                command1.Parameters["@amount"].Value = amount;
                command1.Parameters["@name"].Value = name;

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException)
            {
                transaction.Rollback();
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

        public bool Deposite(string name, double amount) {
            SqlTransaction transaction = null;
            string querymaster = "update BANK_MASTER set balance=balance+" + amount + " where name='" + name + "'";
            string querytransaction = "insert into BANK_TRANSACTION values('" + name + "'," + amount + ",'D','" + DateTime.Now + "')";
            try
            {
                _connection.Open();
                transaction = _connection.BeginTransaction();
                var command1 = new SqlCommand(querymaster, _connection, transaction);
                var command2 = new SqlCommand(querytransaction, _connection, transaction);

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException)
            {
                transaction.Rollback();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return false;
        }
    }
}
