using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace FindProducts
{
    public class FindProducts
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

        private static SqlDataReader FindWordFromProductNames(string searchWord, SqlConnection dbConnection)
        {
            searchWord = searchWord.ToLower();

            var cmdFindWord = new SqlCommand("SELECT p.ProductName FROM Products p WHERE p.ProductName LIKE @searchWord", dbConnection);
            cmdFindWord.Parameters.AddWithValue("@searchWord", '%' + searchWord + '%');

            return cmdFindWord.ExecuteReader();
        }

        static void Main()
        {
            var dbConnection = ConnectToDatabase();
            var searchWord = Console.ReadLine();

            try
            {
                dbConnection.Open();
                var reader = FindWordFromProductNames(searchWord, dbConnection);
                if (reader.Read())
                {
                    Console.WriteLine("Found words: ");
                    do
                    {
                        Console.Write(reader["ProductName"]);
                        Console.Write(' ');
                    }
                    while (reader.Read());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No words found");
                }
                

            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
