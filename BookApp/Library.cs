using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Library
    {
        public event Action<Book> BookAdded;
        public List<Book> Books { get; private set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            BookAdded?.Invoke(book);
        }
        public List<Book> FindBooks(Func<Book, bool> filter)
        {

            return Books.Where(filter).ToList();
        }
    }
}
