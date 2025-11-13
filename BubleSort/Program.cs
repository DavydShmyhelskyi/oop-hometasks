using BubleSort.Services;

int[] numbers = { 5, 3, 9, 1, 7 };

Console.WriteLine("Початковий масив:");
Console.WriteLine(string.Join(", ", numbers));

var ascendingSorter = new BubbleSorter((a, b) => a > b);
ascendingSorter.Sort(numbers);
Console.WriteLine("\nСортування за зростанням");
Console.WriteLine(string.Join(", ", numbers));

var descendingSorter = new BubbleSorter((a, b) => a < b);
descendingSorter.Sort(numbers);
Console.WriteLine("\nСортування за спаданням");
Console.WriteLine(string.Join(", ", numbers));
