using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintNameAndDescriptionOfCategories
{
    // 2.Write a program that retrieves the name and description of all categories in the Northwind DB
    class PrintNameAndDescriptionOfCategories
    {
        static void Main(string[] args)
        {
            string dbName = "localhost";
            SqlConnection dbConnection = new SqlConnection(string.Format("Server={0}; Database=Northwind; Integrated Security=true", dbName));
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand selectCategoriesDescription = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConnection);
                SqlDataReader categoriesReader = selectCategoriesDescription.ExecuteReader();
                using (categoriesReader)
                {
                    while (categoriesReader.Read())
                    {
                        string categoryName = (string)categoriesReader["CategoryName"];
                        string categoryDescription = (string)categoriesReader["Description"];
                        Console.WriteLine("{0} - {1}", categoryName, categoryDescription);
                    }
                }
            }
        }
    }
}
