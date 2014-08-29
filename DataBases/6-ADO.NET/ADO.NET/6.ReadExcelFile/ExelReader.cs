using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace _6.ReadExcelFile
{
    // 6. Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
    class ExcelReader
    {
        static void Main(string[] args)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=scores.xlsx; Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand selectScores = new OleDbCommand("SELECT Name, Score FROM [Sheet1$]", dbConnection);
                OleDbDataReader scoresReader = selectScores.ExecuteReader();

                using (scoresReader)
                {
                    while (scoresReader.Read())
                    {
                        string name = (string)scoresReader["Name"];
                        double score = (double)scoresReader["Score"];

                        Console.WriteLine("{0} {1}", name, score);
                    }
                }
            }
        }
    }
}
