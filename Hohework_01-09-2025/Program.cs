// See https://aka.ms/new-console-template for more information
using Hohework_01_09_2025;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var Murchyk = new Cat("Murchyk", 3);
var Muhtar = new Dog("Muhtar", 5);
var Volandevort = new Snake("Volandevort", 2);
var Vidstrochkoslav = new Cat("Vidstrochkoslav", 5);
var Sharik = new Dog("Sharik", 4);
var Kaa = new Snake("Kaa", 7);

var Cats = new List<Cat> { Murchyk, Vidstrochkoslav };
var Dogs = new List<Dog> { Muhtar, Sharik };
var Snakes = new List<Snake> { Volandevort, Kaa };

Console.WriteLine("Hello!\nChoose animal)");
Console.WriteLine("1 - Dog\n2 - Cat\n3 - Snake");
string choice = Console.ReadLine();
if (choice == "1")
{
    foreach (var dog in Dogs)
    {
        Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, 📢 {dog.Sound()}, 👟 {dog.Walk()}");
    }
}
else if (choice == "2")
{
    foreach (var cat in Cats)
    {
        Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}, 📢 {cat.Sound()}, 👟 {cat.Walk()}");
    }
}
else if (choice == "3")
{
    foreach (var snake in Snakes)
    {
        Console.WriteLine($"Name: {snake.Name}, Age: {snake.Age}, 📢 {snake.Sound()}, 👟 {snake.Walk()}");
    }
}
else
{
    Console.WriteLine("Invalid choice.");
}

