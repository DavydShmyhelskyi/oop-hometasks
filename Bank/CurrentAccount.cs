using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CurrentAccount : BankAcount
    {
        public double OverdraftLimit { get; set; }
        public CurrentAccount(int acountNumber, string accountHolder, double initialBalance, double overdraftLimit)
            : base(acountNumber, accountHolder, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public bool Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
