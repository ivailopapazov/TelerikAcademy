using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _9.MySqlLibrary
{
    class Library
    {
        static void Main(string[] args)
        {
            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["MySQLDB"];
            MySqlConnection dbConnection = new MySqlConnection(connectionSettings.ConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {

            }
        }

        static void ListBooks(MySqlConnection dbConnection)
        {

        }
    }
} 
