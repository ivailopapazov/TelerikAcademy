namespace Articles.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Tag
    {
        private ICollection<Article> articles;

        public Tag()
        {
            this.articles = new HashSet<Article>();
        }
        
        public int Id { get; set; }

        public string Name { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public virtual ICollection<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }
    }
}
