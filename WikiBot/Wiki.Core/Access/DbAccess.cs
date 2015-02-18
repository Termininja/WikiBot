namespace Wiki.Core.Access
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    /// <summary>
    /// Helper class for Database access.
    /// </summary>
    public class DbAccess
    {
        private const string ConnectionString = "Data Source={0};Initial Catalog={1}; Integrated Security=True";

        private string serverName;
        private string databaseName;

        public DbAccess(string serverName, string databaseName)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
        }

        /// <summary>
        /// Gets some data from the Database.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        /// <returns>Returns a list with all requested data.</returns>
        public List<List<object>> GetData(string queryString)
        {
            var result = new List<List<object>>();
            var connectionString = string.Format(ConnectionString, this.serverName, this.databaseName);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(queryString, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            obj.Add(reader.GetValue(i));
                        }

                        result.Add(obj);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Insert, update or delete some database data.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        public void ManipulateData(string queryString)
        {
            var connectionString = string.Format(ConnectionString, this.serverName, this.databaseName);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
