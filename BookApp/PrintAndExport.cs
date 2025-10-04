using BookApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class ConsolePrinter : IPrintable
    {
        public void Print(Book book)
        {
            Console.WriteLine($"{book.Title} - {book.Author} ({book.Year}) [{book.Genre}]");
        }
    }


public class CsvExporter : IExportable
    {
        public void Export(List<Book> books, string filePath)
        {
            var lines = new List<string>();

            lines.Add("Title;Author;Year;Genre");

            lines.AddRange(books.Select(b => $"{b.Title};{b.Author};{b.Year};{b.Genre}"));

            File.WriteAllLines(filePath, lines);
        }
    }


}
