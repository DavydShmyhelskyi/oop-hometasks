using Wallet.Interfaces;

public abstract class BaseDigitalWallet : IDigitalWallet
{
    private readonly List<string> _transactions = new();

    public string Username { get; }
    public string Login { get; protected set; }
    public string PasswordHash { get; protected set;}
    public decimal Balance { get; protected set; }
    public List<string>? Transactions { get; protected set; }

    public BaseDigitalWallet(string username, string login, string password, decimal initialBalance = 0)
    {
        Username = username;
        Login = login;
        PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        Balance = initialBalance;
        Transactions = null;
    }    
    public abstract void SetAuthProvider(ILoginProvider authProvider);
    public abstract bool Deposit(decimal amount);
    public abstract bool Withdraw(decimal amount);
    public abstract decimal CheckBalance();
    public abstract List<string> GetTransactionLog();

    protected void AddTransaction(string record)
    {
        _transactions.Add($"{DateTime.Now}: {record}");
    }

    protected List<string> GetAllTransactions()
    {
        return new List<string>(_transactions);
    }

    protected bool VerifyPassword(string password)
    {
        return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
    }
}

/*public bool Deposit(decimal amount)
    {
        decimal before = Balance;
        Balance += amount;
        _transactions.Add($"+{amount} at {DateTime.Now}");
        if(before < Balance)
        { return true; }
        else 
        { return false; }

    }

    public bool Withdraw(decimal amount)
    {
        decimal before = Balance;
        if (Balance >= amount)
        {
            Balance -= amount;
            _transactions.Add($"{Username}:\n-{amount} at {DateTime.Now}");            
        }
        if(before > Balance)
        { return true; }
        else
        return false;
    }

    public decimal CheckBalance() => Balance;

    public List<string> GetTransactionLog() => new(_transactions);*/