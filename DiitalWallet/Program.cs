using Wallet.Providers;

class Program
{
    static void Main()
    {
        var wallet = new DigitalWallet("mygmail@gmail.com", "12345", 100);

        // Використовуємо Gmail як провайдера
        wallet.SetAuthProvider(new GmailAuthProvider("mygmail@gmail.com", "12345"));

        wallet.Deposit(50);
        wallet.Withdraw(30);

        Console.WriteLine($"Balance: {wallet.CheckBalance()}");
        Console.WriteLine("Transactions: " + string.Join(", ", wallet.GetTransactionLog()));
    }
}
