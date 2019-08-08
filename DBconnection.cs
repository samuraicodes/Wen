using MySql.Data.MySqlClient;

namespace Wen
{
    class DBconnection
    {
        static readonly string logIn = "datasource=127.0.0.1;port=3306;username=root;password=root;database=wen;";
        static MySqlConnection databaseConnection = null;
        static MySqlCommand command = null;

        static public void InitConnection()
        {
            if(databaseConnection == null)
            {
                databaseConnection = new MySqlConnection(logIn);
                databaseConnection.Open();
            }
        }

        static public void EndConnection()
        {
            if(databaseConnection != null)
            {
                databaseConnection.Close();
            }
        }

        public static void ExecuteDelete(string tableName, string condition)
        {
            string sql = "DELETE FROM " + tableName +  " WHERE " + condition + ";";

            PrepareCommand(sql);
    
            command.ExecuteNonQuery();
        }
        public static long ExecuteInsertReturnId(string sql,string name, string url, string description, int collection, int sort)
        {
            PrepareCommand(sql);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@one", name);
            command.Parameters.AddWithValue("@two", url);
            command.Parameters.AddWithValue("@three", description);
            command.Parameters.AddWithValue("@four", collection);
            command.Parameters.AddWithValue("@five", sort);

            command.ExecuteNonQuery();

            return command.LastInsertedId;
        }

        public static long ExecuteInsertReturnId(string sql, string name)
        {
            PrepareCommand(sql);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@one", name);

            command.ExecuteNonQuery();

            return command.LastInsertedId;
        }

        public static MySqlDataReader ExecuteReader(string sql)
        {
            PrepareCommand(sql);
            MySqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        private static void PrepareCommand(string sql)
        {
            command = databaseConnection.CreateCommand();
            command.CommandText = sql;
            command.Prepare();
        }

        

    }
}
