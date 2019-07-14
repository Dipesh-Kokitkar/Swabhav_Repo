using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection =new  SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction=connection.BeginTransaction();
                var command1 = new SqlCommand("update customer set bal=bal-100 where cid=101", connection,transaction);
                var command2 = new SqlCommand("update customer set cname='xyz' where cid=101", connection,transaction);

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("commit");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("rollback ");
                transaction.Rollback();
            }
            catch (Exception e) {
                Console.WriteLine("Error:"+e.Message);
            }
        }
    }
}
