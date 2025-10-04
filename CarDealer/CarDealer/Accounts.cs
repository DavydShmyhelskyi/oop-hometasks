namespace CarDealer.Accounts
{
    public class CurrentAccount
    {
        public double Balance { get; private set; }

        public CurrentAccount(double initialBalance = 0)
        {
            Balance = initialBalance;
        }

        public void AddMoney(double amount)
        {
            Balance += amount;
        }

        public bool WithdrawMoney(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Account Balance: {Balance}$";
        }
    }
}