using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Interfaces
{
    public interface IBookService
    {
        void AddBook(string title, string author, Guid categoryId);
        void EditBook(Guid id, string title, string author);
        void DeleteBook(Guid id);
        IEnumerable<Book> GetAll();
    }
}
