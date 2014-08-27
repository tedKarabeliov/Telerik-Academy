using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace RetrieveImages
{
    public class RetrieveImages
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

        private static SqlDataReader RetrieveImagesFromCategores(SqlConnection dbConnection)
        {
            var cmdRetrieveImages = new SqlCommand("SELECT Picture FROM Categories", dbConnection);
            return cmdRetrieveImages.ExecuteReader();
        }

        static void Main()
        {
            var dbConnection = ConnectToDatabase();

            try
            {
                dbConnection.Open();
                var reader = RetrieveImagesFromCategores(dbConnection);

                var imageCount = 0;
                var header = 78;
                while (reader.Read())
                {
                    imageCount++;
                    var rawData = (byte[])reader["Picture"];
                    var imgData = new byte[rawData.Length - header];
                    var stream = new MemoryStream(imgData);
                    Array.Copy(rawData, header, imgData, 0, rawData.Length - header);

                    var image = Image.FromStream(stream);
                    image.Save(imageCount + "image.jpeg", ImageFormat.Jpeg);
                }
            }
            finally
            {
                dbConnection.Close();
            }
            
        }
    }
}
