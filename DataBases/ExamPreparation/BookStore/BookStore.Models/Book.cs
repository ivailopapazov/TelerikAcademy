namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book
    {
        private ICollection<Review> reviews;
        private ICollection<Author> authors;

        public Book()
        {
            this.reviews = new HashSet<Review>();
            this.authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [MinLength(13)]
        [MaxLength(13)]
        public string ISBN { get; set; }

        public decimal? Price { get; set; }

        public string Website { get; set; }

        public virtual ICollection<Review> Reviews
        {
            get { return reviews; }
            set { reviews = value; }
        }

        public virtual ICollection<Author> Authors
        {
            get { return authors; }
            set { authors = value; }
        }
    }
}
