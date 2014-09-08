namespace BookStore.Data
{
    using BookStore.Data.Migrations;
    using BookStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext()
            : base("BookStoreSqlDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreDbContext, Configuration>());
        }

        public DbSet<Book> Books { get; set; }
        
        public DbSet<Author> Authors { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
