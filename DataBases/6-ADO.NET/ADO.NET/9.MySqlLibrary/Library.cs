using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Globalization;

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
                ListBooks(dbConnection);
                Console.WriteLine(new string('-', 30));
                PrintBookByName(dbConnection, "Harry");
                Console.WriteLine(new string('-', 30));
                long insertedBookId = InsertBook(dbConnection, "testBook", "12312321", DateTime.Now, "Terry Pratchett");
                Console.WriteLine("Book has been inserted with id: " + insertedBookId);
            }
        }

        static void ListBooks(MySqlConnection dbConnection)
        {
            MySqlCommand selectBooks = 
                new MySqlCommand("SELECT b.name AS book_name, b.isbn, b.publishDate, a.name AS author_name FROM books AS b JOIN authors AS a ON b.authors_id = a.id", dbConnection);

            MySqlDataReader bookReader = selectBooks.ExecuteReader();

            using (bookReader)
            {
                while (bookReader.Read())
                {
                    PrintBook(bookReader);
                }
            }
        }

        static void PrintBookByName(MySqlConnection dbConnection, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Book name cannot be null or empty");
            }

            // TODO: string validations and character escape

            MySqlCommand selectBooks =
                new MySqlCommand("SELECT b.name AS book_name, b.isbn, b.publishDate, a.name AS author_name FROM books AS b JOIN authors AS a ON b.authors_id = a.id WHERE b.name LIKE @bookName",
                    dbConnection);

            selectBooks.Parameters.AddWithValue("@bookName", string.Format("{0}{1}{0}", "%", name));

            MySqlDataReader bookReader = selectBooks.ExecuteReader();

            using (bookReader)
            {
                bookReader.Read();
                PrintBook(bookReader);
            }
        }

        static long InsertBook(MySqlConnection dbConnection, string bookName, string isbn, DateTime publishDate, string authorName)
        {
            // TODO: Validations

            MySqlCommand selectAuthorId = new MySqlCommand("SELECT id FROM authors WHERE name = @authorName", dbConnection);
            selectAuthorId.Parameters.AddWithValue("@authorName", authorName);

            int authorId = (int)selectAuthorId.ExecuteScalar();

            MySqlCommand insertIntoBooks = 
                new MySqlCommand("INSERT INTO books(name, isbn, publishDate, authors_id) VALUES (@name, @isbn, @publishDate, @author_id)", dbConnection);

            insertIntoBooks.Parameters.AddWithValue("@name", bookName);
            insertIntoBooks.Parameters.AddWithValue("@isbn", isbn);
            insertIntoBooks.Parameters.AddWithValue("@publishDate", publishDate.ToString("yyyy-MM-dd HH:mm:ss"));
            insertIntoBooks.Parameters.AddWithValue("@author_id", authorId);
            insertIntoBooks.ExecuteNonQuery();

            long insertedBookId = insertIntoBooks.LastInsertedId;
           
            return insertedBookId;
        }

        private static void PrintBook(MySqlDataReader bookReader)
        {
            string bookName = (string)bookReader["book_name"];
            string isbn = (string)bookReader["isbn"];
            MySqlDateTime mySqlDate = bookReader.GetMySqlDateTime("publishDate");
            string authorName = (string)bookReader["author_name"];

            Console.WriteLine("{0} - {1} - {2} - {3}", bookName, isbn, mySqlDate, authorName);
        }
    }
} 
