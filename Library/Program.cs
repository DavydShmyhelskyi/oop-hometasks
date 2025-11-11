using Library.Core.Entities;
using Library.Infrastructure.Repositories;
using Library.Infrastructure.Services;

// Repositories
var userRepo = new InMemoryRepository<User>();
var bookRepo = new InMemoryRepository<Book>();
var categoryRepo = new InMemoryRepository<Category>();

// Services
var emailService = new EmailService();
var categoryService = new CategoryService(categoryRepo);
var userService = new UserService(userRepo, categoryRepo);
var bookService = new BookService(bookRepo, categoryRepo, userRepo, emailService);

// UI
var menu = new LibraryMenu(userService, bookService, categoryService);

menu.Start();
