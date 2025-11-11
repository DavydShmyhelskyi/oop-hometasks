using CalculatorNum;

static void RunIntegerCalculator()
{
    var calc = new Calculator<int>();
    Console.WriteLine("Integer Calculator:");
    Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
    Console.WriteLine($"5 - 3 = {calc.Subtract(5, 3)}");
    Console.WriteLine($"5 * 3 = {calc.Multiply(5, 3)}");
    Console.WriteLine($"9 / 3 = {calc.Divide(9, 3)}");
    Console.WriteLine($"2 ^ 3 = {calc.Pow(2, 3)}");
}

static void RunFloatingCalculator()
{
    var calc = new Calculator<double>();
    Console.WriteLine("\nFloating Calculator:");
    Console.WriteLine($"5.2 + 3.1 = {calc.Add(5.2, 3.1)}");
    Console.WriteLine($"5.2 - 3.1 = {calc.Subtract(5.2, 3.1)}");
    Console.WriteLine($"5.2 * 3.1 = {calc.Multiply(5.2, 3.1)}");
    Console.WriteLine($"6.2 / 3.1 = {calc.Divide(6.2, 3.1)}");
    Console.WriteLine($"2.5 ^ 2 = {calc.Pow(2.5, 2)}");
}

RunIntegerCalculator();
RunFloatingCalculator();