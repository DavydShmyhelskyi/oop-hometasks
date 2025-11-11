using System;

class Program
{
    static void Main()
    {
        var list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddFirst(0);

        Console.WriteLine("All elements:");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine($"Contains 1: {list.Contains(1)}");
        list.Remove(1);
        Console.WriteLine($"Contains 1: {list.Contains(1)}");
        Console.WriteLine($"First: {list.First?.Value}");
        Console.WriteLine($"Last: {list.Last?.Value}");
    }
}
