using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace ExcelSample
{
    public class ExcelSample
    {
        private static OleDbDataReader DisplayNameAndScore(OleDbConnection dbConnection)
        {
            var cmdDisplayNameAndScore = new OleDbCommand("SELECT * FROM [Sheet1$]", dbConnection);
            return cmdDisplayNameAndScore.ExecuteReader();
        }

        private static void AppendRow(OleDbConnection dbConnection)
        {
            var cmdAppendRow = new OleDbCommand(@"INSERT INTO [Sheet1$](name, score)
                                                    Values(@name, @score)", dbConnection);

            cmdAppendRow.Parameters.AddWithValue("@name", "Pesho");
            cmdAppendRow.Parameters.AddWithValue("@score", 50);

            cmdAppendRow.ExecuteNonQuery();
        }

        static void Main()
        {
            //Write a program that reads a MS Excel file through the OLE DB data provider and displays the
            //name and score row by row.

            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SampleExcelDatabase.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

            var dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            var reader = DisplayNameAndScore(dbConnection);

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"] + " -> " + reader["Score"]);
            }

            AppendRow(dbConnection);
        }
    }
}
