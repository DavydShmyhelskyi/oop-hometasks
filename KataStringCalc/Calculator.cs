using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringCalc
{
    public class Calculator
    {
        public int AddNumbers(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            { return 0; }

            if(int.TryParse(numbers, out int singleNumber))
            { return singleNumber; }

            bool startwthslash = numbers.StartsWith("//");
            string[] delimitors = { ",", "\n" };

           if (!startwthslash)
            {
                var nums = numbers.Split(delimitors, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n));
                return nums.Sum();
            }

            if (startwthslash)
            {
                var splitInput = numbers.Split('\n', 2);
                var customDelimitor = splitInput[0].Substring(2);
                var restOfNumbers = splitInput[1];

                delimitors = new string[] { customDelimitor, ",", "\n" };

                var nums = restOfNumbers.Split(delimitors, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n));
                bool hasNegative = nums.Any(n => n < 0);
                if (!hasNegative)
                    return nums.Sum();
                else
                {
                    var negativeNums = nums.Where(n => n < 0);
                    string message = "Negative numbers not allowed: " + string.Join(", ", negativeNums);
                    throw new ArgumentException(message);
                }
            }

            return -999;
            // 1 — якщо numbers == "" або null → повернути 0

            // 2 — якщо рядок містить одне число (без делімітера) → повернути його

            // 3 — Два числа, розділені комою. Приклад: "1,2" -> 3

            // 4 — Будь-яка кількість чисел. Розширення попереднього пункту

            // 5 — Підтримка нового рядка як делімітера. Роздільники: \n та ,

            // 6 — Кастомний делімітeр у форматі //<delim>\n. Приклад: "//;\n1;2" -> 3

            // 7 — Негативні числа кидають виняток із переліком
            // якщо будь-яке число від’ємне -> ArgumentException
            // повідомлення має містити список негативних чисел (наприклад "-2, -5")
        }

    }
}
