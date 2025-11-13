var str = "a, 1, 2, f, -1, 0, 4, 10, 4,f, 4f, 8, 9, 3";

var sum = str.Split(',')
    .Select(s => s.Trim())
    .Where(s => int.TryParse(s, out _)) 
    .Select(int.Parse)
    .OrderBy(n => n)
    .Skip(3)
    .Sum();

Console.WriteLine(sum);

