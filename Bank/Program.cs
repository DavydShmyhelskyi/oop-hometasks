using Bank;
int choice = -3;
while (choice != 0)
{
    Console.WriteLine("Виберіть тип рахунку: 1 - Поточний, 2 - Депозитний\nВийти - 0");
    choice = int.Parse(Console.ReadLine());

    Console.Write("Введіть номер рахунку: ");
    string numberB = Console.ReadLine();
    int number = int.Parse(numberB);

    Console.Write("Введіть ім'я власника рахунку: ");
    string holder = Console.ReadLine();

    Console.Write("Введіть початковий баланс: ");
    double balance = double.Parse(Console.ReadLine());

    BankAcount account = null;

    if (choice == 1)
    {
        Console.Write("Введіть ліміт овердрафту: ");
        double overdraft = double.Parse(Console.ReadLine());

        account = new CurrentAccount(number, holder, balance, overdraft);

        Console.Write("Скільки зняти з рахунку? ");
        double withdraw = double.Parse(Console.ReadLine());

        CurrentAccount ca = (CurrentAccount)account;
        if (ca.Withdraw(withdraw))
            Console.WriteLine($"Знято {withdraw}. Новий баланс: {ca.Balance}");
        else
            Console.WriteLine("Недостатньо коштів, навіть з урахуванням кредиту!");
    }
    else if (choice == 2)
    {
        Console.Write("Введіть відсоткову ставку: ");
        double rate = double.Parse(Console.ReadLine());

        account = new DepositAccount(number, holder, balance, rate);

        DepositAccount da = (DepositAccount)account;
        da.ApplyInterest();
        Console.WriteLine($"Відсотки нараховані. Новий баланс: {da.Balance}");
    }
    else
    {
        Console.WriteLine("Невірний вибір типу рахунку!");
    }

    Console.WriteLine($"Дані рахунку: {account.AcountNumber}, {account.AccountHolder}, Баланс: {account.Balance}");
}
