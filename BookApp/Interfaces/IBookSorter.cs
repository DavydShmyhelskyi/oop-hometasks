using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Interfaces
{
    public interface IBookSorter
    {
        List<Book> Sort(List<Book> books);
    }

    public class SortByTitle : IBookSorter
    {
        public List<Book> Sort(List<Book> books) => books.OrderBy(b => b.Title).ToList();
    }

    public class SortByAuthor : IBookSorter
    {
        public List<Book> Sort(List<Book> books) => books.OrderBy(b => b.Author).ToList();
    }

    public class SortByYear : IBookSorter
    {
        public List<Book> Sort(List<Book> books) => books.OrderBy(b => b.Year).ToList();
    }

}
