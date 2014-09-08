namespace BookStore.Client
{
    using System.Linq;
    using BookStore.Data;

    internal class Program
    {
        static void Main()
        {
            var db = new BookStoreDbContext();
            System.Console.WriteLine(db.Authors.FirstOrDefault());
            var q = db.Books;
            q = q.Where(book => book.Price > 14);
        }
    }
}
