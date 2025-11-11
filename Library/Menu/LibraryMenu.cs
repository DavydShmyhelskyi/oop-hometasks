using Library.Core.Interfaces;

public class LibraryMenu
{
    private readonly IUserService _userService;
    private readonly IBookService _bookService;
    private readonly ICategoryService _categoryService;

    public LibraryMenu(IUserService userService, IBookService bookService, ICategoryService categoryService)
    {
        _userService = userService;
        _bookService = bookService;
        _categoryService = categoryService;
    }

    public void Start()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n=== LIBRARY MENU ===");
            Console.ResetColor();
            Console.WriteLine("1. Users");
            Console.WriteLine("2. Categories");
            Console.WriteLine("3. Books");
            Console.WriteLine("0. Exit");
            Console.Write("Select: ");
            var k = Console.ReadLine();

            switch (k)
            {
                case "1": UsersMenu(); break;
                case "2": CategoryMenu(); break;
                case "3": BookMenu(); break;
                case "0": return;
            }
        }
    }

    private void UsersMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Users ---");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Edit user");
            Console.WriteLine("3. Delete user");
            Console.WriteLine("4. Subscribe to category");
            Console.WriteLine("5. List users");
            Console.WriteLine("0. Back");
            var k = Console.ReadLine();

            var users = _userService.GetAll().ToList();

            switch (k)
            {
                case "1":
                    Console.Write("Name: "); var n = Console.ReadLine();
                    Console.Write("Email: "); var e = Console.ReadLine();
                    _userService.Register(n!, e!);
                    break;
                case "2":
                    if (!users.Any()) break;
                    Show(users);
                    Console.Write("Select user #: ");
                    var idx = int.Parse(Console.ReadLine()!) - 1;
                    Console.Write("New name: "); var nn = Console.ReadLine();
                    Console.Write("New email: "); var ne = Console.ReadLine();
                    _userService.Edit(users[idx].Id, nn!, ne!);
                    break;
                case "3":
                    if (!users.Any()) break;
                    Show(users);
                    Console.Write("Delete user #: ");
                    idx = int.Parse(Console.ReadLine()!) - 1;
                    _userService.Delete(users[idx].Id);
                    break;
                case "4":
                    if (!users.Any()) break;
                    Show(users);
                    Console.Write("Select user #: ");
                    idx = int.Parse(Console.ReadLine()!) - 1;
                    var cats = _categoryService.GetAll().ToList();
                    Show(cats);
                    Console.Write("Select category #: ");
                    var cidx = int.Parse(Console.ReadLine()!) - 1;
                    _userService.Subscribe(users[idx].Id, cats[cidx].Id);
                    Console.WriteLine($"User {users[idx].Name} subscribed to {cats[cidx].Name}");
                    break;
                case "5":
                    Show(users);
                    break;
                case "0":
                    return;
            }
        }
    }

    private void CategoryMenu()
    {
        Console.Write("New category name: ");
        var n = Console.ReadLine();
        _categoryService.AddCategory(n!);
    }

    private void BookMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Books ---");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. List");
            Console.WriteLine("0. Back");
            var k = Console.ReadLine();

            var books = _bookService.GetAll().ToList();
            var cats = _categoryService.GetAll().ToList();

            switch (k)
            {
                case "1":
                    Console.Write("Title: "); var t = Console.ReadLine();
                    Console.Write("Author: "); var a = Console.ReadLine();
                    Show(cats);
                    Console.Write("Select category #: ");
                    var ci = int.Parse(Console.ReadLine()!) - 1;
                    _bookService.AddBook(t!, a!, cats[ci].Id);
                    break;
                case "2":
                    if (!books.Any()) break;
                    Show(books);
                    Console.Write("Select #: ");
                    var bi = int.Parse(Console.ReadLine()!) - 1;
                    Console.Write("New title: "); var nt = Console.ReadLine();
                    Console.Write("New author: "); var na = Console.ReadLine();
                    _bookService.EditBook(books[bi].Id, nt!, na!);
                    break;
                case "3":
                    if (!books.Any()) break;
                    Show(books);
                    Console.Write("Delete #: ");
                    bi = int.Parse(Console.ReadLine()!) - 1;
                    _bookService.DeleteBook(books[bi].Id);
                    break;
                case "4":
                    Show(books);
                    break;
                case "0":
                    return;
            }
        }
    }

    private void Show<T>(IEnumerable<T> list)
    {
        var arr = list.ToList();
        for (int i = 0; i < arr.Count; i++)
            Console.WriteLine($"{i + 1}. {arr[i]}");
    }
}