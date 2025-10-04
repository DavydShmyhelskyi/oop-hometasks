using System;
using System.IO;

namespace BookApp
{
    public class Logger
    {
        private readonly string _filePath;

        public Logger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogBookAdded(Book book)
        {
            var message = $"Book added: {book.Title}{Environment.NewLine}";
            File.AppendAllText(_filePath, message);
        }
    }
}