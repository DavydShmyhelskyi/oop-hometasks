using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Accounts
{    
        public class CurrentAccount : IAccount
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

        public override string ToString() => $"Account Balance: {Balance}$";
    }
}

