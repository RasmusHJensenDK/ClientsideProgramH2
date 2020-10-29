using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ClientsideH2.Repositories
{
    public class DatabaseWrapper
    {
        private readonly string _connectionString;
        public DatabaseWrapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ExecuteQuery(string query)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    string abc = "l";
                }
            }
        }
        public SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection;
        }
    }
}
