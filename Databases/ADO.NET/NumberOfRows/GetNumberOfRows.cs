using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NumberOfRows
{
    public class GetNumberOfRows
    {
        private static SqlConnection ConnectToDatabase()
        {
            var dbConnectionString = ConfigurationManager.ConnectionStrings["SQLDB"];
            var dbConnection = new SqlConnection(dbConnectionString.ConnectionString);

            return dbConnection;
        }

        private static void DisconnectFromDatabase(IDbConnection connection)
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        private static int GetNumberOfRowsInCategoriesTable(SqlConnection dbConnection)
        {
            var sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConnection);
            return (int)sqlCommand.ExecuteScalar();
        }

        static void Main(string[] args)
        {
            var dbConnection = ConnectToDatabase();

            try
            {
                dbConnection.Open();

                var numberOfRows = GetNumberOfRowsInCategoriesTable(dbConnection);
                Console.WriteLine("Number of Categories - " + numberOfRows);
            }
            finally
            {
                DisconnectFromDatabase(dbConnection);
            }
        }
    }
}
