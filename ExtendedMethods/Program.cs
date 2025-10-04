using System;

namespace IntExtensionsDemo
{
    public static class IntExtensions
    {
        public static int DigitCount(this int number)
        {
            return Math.Abs(number).ToString().Length;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsGreaterThan(this int number, int other)
        {
            return number > other;
        }

        public static bool IsLessThan(this int number, int other)
        {
            return number < other;
        }

        public static bool IsEqualTo(this int number, int other)
        {
            return number == other;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;

            Console.WriteLine($"Кількість цифр: {num.DigitCount()}");   // 4
            Console.WriteLine($"Парне? {num.IsEven()}");                // True
            Console.WriteLine($"Непарне? {num.IsOdd()}");               // False
            Console.WriteLine($"Більше 1000? {num.IsGreaterThan(1000)}"); // True
            Console.WriteLine($"Менше 5000? {num.IsLessThan(5000)}");     // True
            Console.WriteLine($"Рівне 1234? {num.IsEqualTo(1234)}");      // True
        }
    }
}
