using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _8.SearchProducts
{
    // 8.Write a program that reads a string from the console and finds all products that contain this string. Ensure you handle correctly characters like ', %, ", \ and _.
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput;
            string searchWord;

            do
            {
                Console.Write("Enter product string: ");
                searchWord = Console.ReadLine();
                isValidInput = IsValidString(searchWord);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid Input!");
                }

            } while (!isValidInput);

            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["SQLDB"];
            SqlConnection dbConnection = new SqlConnection(connectionSettings.ConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand selectProduct = 
                    new SqlCommand("SELECT ProductID, ProductName FROM Products WHERE ProductName LIKE @product", dbConnection);

                selectProduct.Parameters.AddWithValue("@product", string.Format("{0}{1}{0}", "%", searchWord));

                SqlDataReader productReader = selectProduct.ExecuteReader();
                using (productReader)
                {
                    while (productReader.Read())
                    {
                        int id = (int)productReader["productID"];
                        string name = (string)productReader["ProductName"];

                        Console.WriteLine("{0} - {1}", id, name);
                    }
                }
            }
        }

        static bool IsValidString(string word)
        {
            string[] splitedWord = word.Split(new char[] { '\'', '%', '"', '\\', '_' });

            if (splitedWord.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
