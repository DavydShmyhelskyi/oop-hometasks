using CalculatorNum;
using System.Numerics;

static void RunCalculator<T>(Calculator<T> calc, T a, T b)
    where T : INumber<T>
{
    Console.WriteLine("Integer Calculator:");
    Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
    Console.WriteLine($"{a} - {b} = {calc.Subtract(a, b)}");
    Console.WriteLine($"{a} * {b} = {calc.Multiply(a, b)}");
    Console.WriteLine($"{a} / {b} = {calc.Divide(a, b)}");
    Console.WriteLine($"{a} ^ {b} = {calc.Pow(a, b)}");
}



RunCalculator(new Calculator<int>(), 5, 3);
RunCalculator(new Calculator<double>(), 5.2, 3.1);


