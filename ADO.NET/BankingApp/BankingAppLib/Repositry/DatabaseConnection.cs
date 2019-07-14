using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingAppLib
{
    class DatabaseConnection
    {
        private static SqlConnection _connection=null;

        private DatabaseConnection() { }

        public static SqlConnection getConnection() {
            if (_connection == null) {
                _connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AurionPro;Integrated Security=True");
            }
            return _connection;
        }
    }
}
