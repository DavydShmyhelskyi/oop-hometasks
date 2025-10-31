// Shmyhelskyi David (KN-313)

//Integer 7. Дано двозначне число. Знайти суму та добуток його цифр.

int number = 34; 

int getSumOfDigits(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    return firstDigit + secondDigit;
}
int getProductOfDigits(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit * secondDigit;
}

Console.WriteLine("Sum of digits: " + getSumOfDigits(number));
Console.WriteLine("Product of digits: " + getProductOfDigits(number));

/*
Integer 25. Дні тижня пронумеровані наступним чином:
0 – неділя, 1 – понеділок, 2 – вівторок, … , 6 – субота.
Дано ціле число K , що лежить у діапазоні 1-365.
Визначити номер дня тижня для K -го дня, якщо відомо,
що цього року 1 січня було четвергом.
*/

int firstJanuaryDayOfWeek = 4; 
int K = 256;

int getDayOfWeek(int firstJanuaryDayOfWeek, int K)
{
    int dayOfWeek = K % 7;
    dayOfWeek = (dayOfWeek + firstJanuaryDayOfWeek - 1) % 7;

    return dayOfWeek;
}

Console.WriteLine("Day of the week for K-th day: " + getDayOfWeek(firstJanuaryDayOfWeek, K));

/*
Boolean 38. Дано координати двох різних полів шахової дошки x1 , y1 , x2 , y2 (цілі числа, що лежать у діапазоні 1–8). 
Перевірити істинність висловлювання: «Слон за один хід може перейти з поля на інше».
Підказка: слон ходить по діагоналі.
*/

int x1 = 3;
int y1 = 4;

int x2 = 6;
int y2 = 7;

bool canBishopMove(int x1, int y1, int x2, int y2)
{
    return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
}

/*
  If 18 . Дано три цілих числа,
  одне з яких відмінно від двох інших, рівних між собою.
  Визначити порядковий номер числа, відмінного від інших. 
*/

int a = 5;
int b = 5;
int c = 10;

int GetDifferentNumberIndex(int a, int b, int c)
{
    if (a == b)
    {
        return 3; 
    }
    else if (a == c)
    {
        return 2; 
    }
    else
    {
        return 1; 
    }
}

Console.WriteLine("Index of the different number: " + GetDifferentNumberIndex(a, b, c));

/*
For 10 . Дано ціле число N (> 0). Знайти суму 1 + 1/2 + 1/3 + ... + 1/ N .
 */

int N = 5;

double GetSum(int N)
{
    double sum = 0.0;
    for (int i = 1; i <= N; i++)
    {
        sum += 1.0 / i;
    }
    return sum;
}
Console.WriteLine("Sum: " + GetSum(N));

/*
 For 25 . Дано дійсне число X і ціле число N (> 0). Знайти значення виразу 

1 + x + x^2/(2!) + x^3/(3!) + ... + x^N/(N!)

 Отримане число є наближеним значенням функції exp у точці X.
*/

double X = 2.0;
N = 5;

double GetExpressionValue(double X, int N)
{
    double sum = 1.0;
    double factorial = 1.0;
    double powerOfX = 1.0;
    for (int i = 1; i <= N; i++)
    {
        powerOfX *= X; 
        factorial *= i; 
        sum += powerOfX / factorial;
    }
    return sum;
}

Console.WriteLine("Expression Value: " + GetExpressionValue(X, N));

/*
 * While 10 . Дано ціле число N (> 1). Знайти найбільше ціле число K , за якого виконується нерівність 3^К < N
 */

N= 50;
K = 0;
while (Math.Pow(3, b) < N)
{
    int powerOf3 = 1;

    powerOf3 *= 3;
    K++;

    Console.WriteLine("Largest integer K such that 3^K < N: " + K);
}

/*
 * Series 17 . 
 * Дано ціле число N (> 2) і набір N дійсних чисел. 
 * Набір називається пилкоподібним , 
 * якщо кожен його внутрішній елемент або більше,
 * або менше обох своїх сусідів (тобто є зубцем). Якщо даний набір є пилкоподібним, вивести 0;
 * в іншому випадку вивести номер першого елемента, що не є зубцем.
 */




/*
 * Proc29 . Описати функцію DigitCount ( K ) цілого типу , що знаходить кількість цифр цілого позитивного числа K.
 */

K = 8162514;
int DigitCount(int K)
{
    int count = 0;
    while (K > 0)
    {
        K /= 10;
        count++;
    }
    return count;
}
Console.WriteLine($"Count of number{K}: " + K);


/*
 * Minmax 24 . Дано ціле число N (> 3) і набір N чисел. Знайти три найбільші елементи з даного набору і вивести ці елементи в порядку зменшення їх значень
 */

N = 7;
int[] arr1 = { 5, 12, 3, 9, 20, 15, 8 };
Array.Sort(arr1);
Array.Reverse(arr1);
int[] top3 = [arr1[1], arr1[2], arr1[3]];


/*
 * Array 28 . Даний масив A розміру N. _ Знайти мінімальний елемент його елементів з парними номерами:
 */

N = 7;
int[] A = { 5, 2, 8, 1, 4, 7, 3 };

int minEvenIndex = -1;

for (int i = 2; i < N; i += 2)
{
    if (A[i] < minEvenIndex)
        minEvenIndex = A[i];
}
if (minEvenIndex < 0) {
    Console.WriteLine("Немфє парних")}
else {
    Console.WriteLine($"Мінімальний елемент з парними номерами: {minEvenIndex}");
}


/*
 * Array 47. Дано масив розміру N . Знайти кількість різних елементів у цьому масиві
 * */

/*
 * Array 74 . Дано масив розміру N . Обнулити елементи масиву, розташовані між його мінімальним та максимальним елементами (не включаючи мінімальний та максимальний елементи). Вважати, що такі елементи є унікальними
 * */