using BookApp;
using BookApp.Interfaces;

var library = new Library();
var logger = new Logger("books.log");

library.BookAdded += book => Console.WriteLine($"Книга додана: {book.Title}");
library.BookAdded += logger.LogBookAdded;

library.AddBook(new Book("1984", "George Orwell", 1949, "Dystopia"));
library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932, "Sci-Fi"));
library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy"));

var fantasyBooks = library.FindBooks(b => b.Genre == "Fantasy");

IBookSorter sorter = new SortByTitle();
var sorted = sorter.Sort(library.Books);

var printer = new ConsolePrinter();
foreach (var book in sorted) printer.Print(book);

var exporter = new CsvExporter();
exporter.Export(library.Books, "books.csv");
