using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RetrieveNamesDescriptions
{
    public class RetrieveNamesDescriptions
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

        private static SqlDataReader RetrieveNameAndDescriptionOfAllCategories(SqlConnection dbConnection)
        {
            var sqlCommand = new SqlCommand("Select c.CategoryName, c.Description FROM Categories c", dbConnection);
            return sqlCommand.ExecuteReader();
        }

        static void Main()
        {
            var dbConnection = ConnectToDatabase();
            
            try
            {
                dbConnection.Open();
                var reader = RetrieveNameAndDescriptionOfAllCategories(dbConnection);
                using (reader)
                {
                    Console.WriteLine("Retrieving Category Names And Descriptions..");
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["CategoryName"] + " - " + reader["Description"]);
                    }
                }
            }
            finally
            {
                dbConnection.Close();
            }
            
        }
    }
}
