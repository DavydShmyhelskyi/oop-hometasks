var str = "a, 1, 2, f, -1, 0, 4, 10, 4,f, 4f, 8, 9, 3";

var sum = str.Split(',')
    .Select(s => s.Trim())
    .Where(s => int.TryParse(s, out _)) 
    .Select(int.Parse)
    .OrderBy(n => n)
    .Skip(3)
    .Sum();

Console.WriteLine(sum);


/*| Категорія    | Приклади                    | Тип делегата       | Що повертають         |
| ------------ | --------------------------- | ------------------ | --------------------- |
| Фільтрація   | `Where`, `Any`, `All`       | `Func<T, bool>`    | ті ж самі або `bool`  |
| Перетворення | `Select`, `SelectMany`      | `Func<T, TResult>` | нова колекція         |
| Сортування   | `OrderBy`, `ThenBy`         | `Func<T, TKey>`    | впорядкована колекція |
| Групування   | `GroupBy`, `Join`           | `Func<T, TKey>`    | групи або з’єднання   |
| Підсумок     | `Aggregate`, `Sum`, `Count` |  різні `Func`      | одне значення         |
| Вибір        | `First`, `Last`, `Single`   | `Func<T, bool>`    | 1 елемент             |
*/