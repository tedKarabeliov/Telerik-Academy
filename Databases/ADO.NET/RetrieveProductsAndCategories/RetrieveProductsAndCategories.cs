using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Wintellect.PowerCollections;

namespace RetrieveProductsAndCategories
{
    public class RetrieveProductsAndCategories
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

        private static SqlDataReader RetrieveCategoriesAndProducts(SqlConnection dbConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT p.ProductName, c.CategoryName
                                            FROM Products p
                                            JOIN Categories c ON p.CategoryID = c.CategoryID
                                            ORDER BY c.CategoryName", dbConnection);
            return sqlCommand.ExecuteReader();
        }

        static void Main()
        {
            var dbConnection = ConnectToDatabase();
            try
            {
                dbConnection.Open();

                var reader = RetrieveCategoriesAndProducts(dbConnection);
                var categoriesAndProducts = new MultiDictionary<string, string>(true);
                using (reader)
                {
                    while (reader.Read())
                    {
                        categoriesAndProducts.Add((string)reader["CategoryName"], (string)reader["ProductName"]);
                    }
                }

                Console.WriteLine("Categories with their products..");

                categoriesAndProducts.ForEach(c =>
                {
                    Console.Write(c.Key + " ->");
                    foreach (var product in c.Value)
                    {
                        Console.Write(' ' + product);
                    }
                    Console.WriteLine();
                });
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
