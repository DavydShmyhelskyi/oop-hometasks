using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalc
{
    public class Calculator
    {
        
        public int AddNumbers(string numbers)
        {
            int result = -999;
            if (string.IsNullOrEmpty(numbers))
            {
                result = 0;
            }
            return result;
        }
        // 1 — якщо numbers == "" або null → повернути 0

        // 2 — якщо рядок містить одне число (без делімітера) → повернути його

        // 3 — Два числа, розділені комою. Приклад: "1,2" -> 3

        // 4 — Будь-яка кількість чисел. Розширення попереднього пункту

        // 5 — Підтримка нового рядка як делімітера. Роздільники: \n та ,

        // 6 — Кастомний делімітeр у форматі //<delim>\n

        // 7 — Негативні числа кидають виняток із переліком
        // якщо будь-яке число від’ємне -> ArgumentException
        // повідомлення має містити список негативних чисел (наприклад "-2, -5")

    }
}
