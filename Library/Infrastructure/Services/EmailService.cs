using Library.Core.Entities;
using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public void NotifySubscribers(Category category, Book book, IEnumerable<User> users)
        {
            var subs = users.Where(u => u.Subscriptions.Contains(category));
            foreach (var user in subs)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Email to {user.Email}: new book '{book.Title}' in {category.Name}");
                Console.ResetColor();
            }
        }
    }
}
