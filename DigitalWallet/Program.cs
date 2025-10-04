using DigitalWalletApp.Entities;
using DigitalWalletApp.Interfaces;
using DigitalWalletApp.Providers;
using DigitalWalletApp.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Створення користувача та гаманця
User user = UserInitializer.CreateDefault();
DigitalWallet wallet = WalletInitializer.CreateDefault(user);

// Провайдери логіну
IloginProvider gmailProvider = new GmailProvider();
IloginProvider privatProvider = new Privat24Provider();

// Сервіс гаманця
IDigitalWalletService walletService = new DigitallWalletService();

Console.WriteLine("=== Digital Wallet Console ===");
Console.WriteLine("Оберіть спосіб входу:");
Console.WriteLine("1. Gmail");
Console.WriteLine("2. Privat24");
Console.WriteLine("0. Вихід");
Console.Write("Ваш вибір: ");
string providerChoice = Console.ReadLine();

IloginProvider selectedProvider = null;

while (providerChoice != "0" && providerChoice != "1" && providerChoice != "2")
{     Console.WriteLine("❌ Невірний вибір!\nСпробуйте ще раз");
    providerChoice = Console.ReadLine();
}
switch (providerChoice)
{
    case "1":
        selectedProvider = gmailProvider;
        Console.Write("Введіть email: ");
        break;
    case "2":
        selectedProvider = privatProvider;
        Console.Write("Введіть номер телефону: ");
        break;
    case "0":
        Console.WriteLine("👋 Вихід...");
        return;
}

string login = Console.ReadLine();

Console.Write("Введіть пароль: ");
string password = Console.ReadLine();

// Перевірка входу
bool authenticated = selectedProvider.ValidateLogin(user, wallet, login, password);

if (!authenticated)
{
    Console.WriteLine("❌ Невірні дані входу!");
    return;
}

Console.WriteLine("✅ Вхід успішний!");

while (true)
{
    Console.WriteLine("\n=== Меню ===");
    Console.WriteLine("1. Перевірити баланс");
    Console.WriteLine("2. Поповнити гаманець");
    Console.WriteLine("3. Зняти гроші");
    Console.WriteLine("4. Історія транзакцій");
    Console.WriteLine("5. Вийти");
    Console.Write("Оберіть опцію: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine($"Ваш баланс: {walletService.CheckBalance(wallet)} грн");
            break;

        case "2":
            Console.Write("Сума для поповнення: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            walletService.Deposit(wallet, depositAmount);
            Console.WriteLine("✅ Поповнено!");
            break;

        case "3":
            Console.Write("Сума для зняття: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            try
            {
                walletService.Withdraw(wallet, withdrawAmount);
                Console.WriteLine("✅ Гроші знято!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Помилка: {ex.Message}");
            }
            break;

        case "4":
            var transactions = walletService.GetTransactionLog(wallet);
            Console.WriteLine("=== Історія транзакцій ===");
            foreach (var t in transactions)
            {
                Console.WriteLine(t);
            }
            break;

        case "5":
            Console.WriteLine("👋 Вихід...");
            return;

        default:
            Console.WriteLine("❌ Невірний вибір!");
            break;
    }
}