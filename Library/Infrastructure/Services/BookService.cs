using Library.Core.Entities;
using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepo;
        private readonly IRepository<Category> catRepo;
        private readonly IRepository<User> userRepo;
        private readonly IEmailService emailService;

        public BookService(
            IRepository<Book> bookRepo,
            IRepository<Category> catRepo,
            IRepository<User> userRepo,
            IEmailService emailService)
        {
            bookRepo = bookRepo;
            catRepo = catRepo;
            userRepo = userRepo;
            emailService = emailService;
        }

        public void AddBook(string title, string author, Guid categoryId)
        {
            var category = catRepo.GetById(categoryId);
            if (category == null) return;

            var book = new Book(title, author, category);
            bookRepo.Add(book);

            emailService.NotifySubscribers(category, book, userRepo.GetAll());
        }

        public void EditBook(Guid id, string title, string author)
        {
            var book = bookRepo.GetById(id);
            if (book == null) return;
            book.Title = title;
            book.Author = author;
        }

        public void DeleteBook(Guid id) => bookRepo.Remove(id);

        public IEnumerable<Book> GetAll() => bookRepo.GetAll();
    }
}
