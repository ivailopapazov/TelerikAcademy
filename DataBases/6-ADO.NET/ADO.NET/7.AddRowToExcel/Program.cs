using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace _6.ReadExcelFile
{
    // 7. Implement appending new rows to the Excel file.
    class ExcelReader
    {
        static void Main(string[] args)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=scores.xlsx; Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand selectScores = 
                    new OleDbCommand("INSERT INTO [Sheet1$](name, score) VALUES (@name, @score)", dbConnection);

                string name = "Pesho Gosho";
                double score = 0;

                selectScores.Parameters.AddWithValue("@name", name);
                selectScores.Parameters.AddWithValue("@score", score);

                selectScores.ExecuteNonQuery();
            }
        }
    }
}
