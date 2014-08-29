using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintProducts
{
    // 3.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. Can you do this with a single SQL query (with table join)?
    class PrintProducts
    {
        static void Main(string[] args)
        {
            string dbName = "localhost";
            SqlConnection dbConnection = new SqlConnection(string.Format("Server={0}; Database=Northwind; Integrated Security=true", dbName));
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand selectProductsAndCategories = 
                    new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Products AS p JOIN Categories AS c ON p.CategoryID = c.CategoryID ORDER BY c.CategoryName", dbConnection);

                SqlDataReader products = selectProductsAndCategories.ExecuteReader();
                using (products)
                {
                    while (products.Read())
                    {
                        string categoryName = (string)products["CategoryName"];
                        string productName = (string)products["productName"];
                        Console.WriteLine("{0} - {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
