namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Author
    {
        private ICollection<Review> reviews;
        private ICollection<Book> books;

        public Author()
        {
            this.reviews = new HashSet<Review>();
            this.books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Review> Reviews
        {
            get { return reviews; }
            set { reviews = value; }
        }
        public ICollection<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
    }
}
