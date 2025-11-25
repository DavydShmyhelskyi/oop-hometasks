using Library.Core.Entities;
using Library.Infrastructure.Repositories;
using Library.Infrastructure.Services;
using Library.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Repositories
services.AddSingleton<IRepository<User>, InMemoryRepository<User>>();
services.AddSingleton<IRepository<Book>, InMemoryRepository<Book>>();
services.AddSingleton<IRepository<Category>, InMemoryRepository<Category>>();



// Services
services.AddSingleton<IEmailService, EmailService>();
services.AddSingleton<ICategoryService, CategoryService>();
services.AddSingleton<IUserService, UserService>();
services.AddSingleton<IBookService, BookService>();

// UI
services.AddSingleton<LibraryMenu>();
var provider = services.BuildServiceProvider();
var menu = provider.GetRequiredService<LibraryMenu>();
menu.Start();

//додати IOC та знати патерни