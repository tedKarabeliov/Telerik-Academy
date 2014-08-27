using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AddNewProduct
{
    public class AddNewProductToDB
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

        private static int AddNewProduct(SqlConnection dbConnection,
                            string productName,
                            int supplierID,
                            int categoryID,
                            string quantityPerUnit,
                            decimal unitPrice,
                            int unitsInStock,
                            int unitsInOrder,
                            int reorderLevel,
                            int discontinued)
        {
            var cmdInsertProduct = new SqlCommand(@"INSERT INTO Products(ProductName, SupplierID, CategoryID,
                                                QuantityPerUnit, UnitPrice, UnitsInStock,
                                                UnitsOnOrder, ReorderLevel, Discontinued)
                                                VALUES(@productName, @supplierID, @categoryID,
                                                @quantityPerUnit, @unitPrice, @unitsInStock,
                                                @unitsOnOrder, @reorderLevel, @discontinued)", dbConnection);

            cmdInsertProduct.Parameters.AddWithValue("@productname", productName);
            cmdInsertProduct.Parameters.AddWithValue("@supplierID", supplierID);
            cmdInsertProduct.Parameters.AddWithValue("@categoryID", categoryID);
            cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmdInsertProduct.Parameters.AddWithValue("@unitPrice", unitPrice);
            cmdInsertProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            cmdInsertProduct.Parameters.AddWithValue("@unitsOnOrder", unitsInOrder);
            cmdInsertProduct.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmdInsertProduct.Parameters.AddWithValue("@discontinued", discontinued);
            cmdInsertProduct.ExecuteNonQuery();

            var cmdSelectIdentity = new SqlCommand("SELECT @@IDENTITY", dbConnection);
            return (int)(decimal)cmdSelectIdentity.ExecuteScalar();
        }

        static void Main()
        {
            SqlConnection dbConnection = ConnectToDatabase();

            try
            {
                dbConnection.Open();
                var newProductID = AddNewProduct(dbConnection, "SampleProduct", 1, 1, "some boxes", 10, 5, 5, 5, 5);
                Console.WriteLine("Added new product with id - " + newProductID);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
