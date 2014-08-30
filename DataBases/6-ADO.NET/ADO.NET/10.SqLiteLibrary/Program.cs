using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace _10.SqLiteLibrary
{
    // 10.Re-implement the previous task with SQLite embedded DB 
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["SqLiteDB"];
            SQLiteConnection dbConnection = new SQLiteConnection(connectionSettings.ConnectionString);
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

        static void ListBooks(SQLiteConnection dbConnection)
        {
            SQLiteCommand selectBooks = 
                new SQLiteCommand("SELECT b.name AS book_name, b.isbn, b.publishDate, a.name AS author_name FROM books AS b JOIN authors AS a ON b.authors_id = a.id", dbConnection);

            SQLiteDataReader bookReader = selectBooks.ExecuteReader();

            using (bookReader)
            {
                while (bookReader.Read())
                {
                    PrintBook(bookReader);
                }
            }
        }

        static void PrintBookByName(SQLiteConnection dbConnection, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Book name cannot be null or empty");
            }

            // TODO: string validations and character escape

            SQLiteCommand selectBooks =
                new SQLiteCommand("SELECT b.name AS book_name, b.isbn, b.publishDate, a.name AS author_name FROM books AS b JOIN authors AS a ON b.authors_id = a.id WHERE b.name LIKE @bookName",
                    dbConnection);

            selectBooks.Parameters.AddWithValue("@bookName", string.Format("{0}{1}{0}", "%", name));

            SQLiteDataReader bookReader = selectBooks.ExecuteReader();

            using (bookReader)
            {
                bookReader.Read();
                PrintBook(bookReader);
            }
        }

        static long InsertBook(SQLiteConnection dbConnection, string bookName, string isbn, DateTime publishDate, string authorName)
        {
            // TODO: Validations

            SQLiteCommand selectAuthorId = new SQLiteCommand("SELECT id FROM authors WHERE name = @authorName", dbConnection);
            selectAuthorId.Parameters.AddWithValue("@authorName", authorName);

            long authorId = (long)selectAuthorId.ExecuteScalar();

            SQLiteCommand insertIntoBooks = 
                new SQLiteCommand("INSERT INTO books(name, isbn, publishDate, authors_id) VALUES (@name, @isbn, @publishDate, @author_id)", dbConnection);

            insertIntoBooks.Parameters.AddWithValue("@name", bookName);
            insertIntoBooks.Parameters.AddWithValue("@isbn", isbn);
            insertIntoBooks.Parameters.AddWithValue("@publishDate", publishDate.ToString("yyyy-MM-dd HH:mm:ss"));
            insertIntoBooks.Parameters.AddWithValue("@author_id", authorId);
            insertIntoBooks.ExecuteNonQuery();

            SQLiteCommand selectLastId = new SQLiteCommand("SELECT last_insert_rowid()", dbConnection);
            long insertedBookId = (long)selectLastId.ExecuteScalar();
           
            return insertedBookId;
        }

        private static void PrintBook(SQLiteDataReader bookReader)
        {
            string bookName = (string)bookReader["book_name"];
            string isbn = (string)bookReader["isbn"];
            DateTime mySqlDate = bookReader.GetDateTime(2);
            string authorName = (string)bookReader["author_name"];

            Console.WriteLine("{0} - {1} - {2} - {3}", bookName, isbn, mySqlDate, authorName);
        }
    }
}
