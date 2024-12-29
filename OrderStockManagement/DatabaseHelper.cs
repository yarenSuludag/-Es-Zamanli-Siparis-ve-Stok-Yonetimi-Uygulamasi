using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace OrderStockManagement
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=OrderStockManagement;Uid=root;Pwd=11092001;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
