using System;
using System.Data.SqlClient;

namespace _1.NumberOfCategories
{
    // 1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
    class NumberOfCategories
    {
        static void Main(string[] args)
        {
            string databaseName = "localhost";
            SqlConnection DbConnection = new SqlConnection(string.Format("Server={0}; Database=Northwind; Integrated Security=true", databaseName));
            DbConnection.Open();

            using (DbConnection)
            {
                SqlCommand selectNumberOfCategories = new SqlCommand("SELECT COUNT(*) FROM Categories", DbConnection);
                int numberOfCategories = (int)selectNumberOfCategories.ExecuteScalar();
                Console.WriteLine(numberOfCategories);
            }
        }
    }
}
