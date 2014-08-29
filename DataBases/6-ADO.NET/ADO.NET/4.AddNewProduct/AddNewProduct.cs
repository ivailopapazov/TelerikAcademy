using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AddNewProduct
{
    // 4.Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.
    class AddNewProduct
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection(ConnectionSettings.Default.SqlDbConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                int newProductId = InsertProduct(dbConnection,  "Honey", 6, 7, "1 Jar", 10.2M, 54, 4, 1, false);
                Console.WriteLine("Product ID: " + newProductId);
            }
        }

        public static int InsertProduct(
            SqlConnection connection, 
            string productName, 
            int supplierId, 
            int categoryId, 
            string quantityPerUnit,
            decimal price, 
            short unitsInStock, 
            short unitsOnOrder,
            short reorderLevel,
            bool discontinued)
        {
            string insertQuery = @"INSERT Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) 
                VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)";

            SqlCommand insertProductCommand = new SqlCommand(insertQuery, connection);

            insertProductCommand.Parameters.AddWithValue("@productName", productName);
            insertProductCommand.Parameters.AddWithValue("@supplierID", supplierId);
            insertProductCommand.Parameters.AddWithValue("@categoryID", categoryId);
            insertProductCommand.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            insertProductCommand.Parameters.AddWithValue("@unitPrice", price);
            insertProductCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            insertProductCommand.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            insertProductCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            insertProductCommand.Parameters.AddWithValue("@discontinued", discontinued);

            insertProductCommand.ExecuteNonQuery();

            SqlCommand selectIdentityCommand = new SqlCommand("SELECT @@Identity", connection);
            int insertedRecordId = (int)(decimal)selectIdentityCommand.ExecuteScalar();
            return insertedRecordId;
        }
    }

}
