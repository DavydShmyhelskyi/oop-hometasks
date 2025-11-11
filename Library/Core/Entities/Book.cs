using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public Category Category { get; set; }

        public Book(string title, string author, Category category)
        {
            Title = title;
            Author = author;
            Category = category;
        }

        public override string ToString() => $"{Title} by {Author} [{Category.Name}]";
    }
}
