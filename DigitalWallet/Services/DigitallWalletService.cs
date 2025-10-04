using DigitalWalletApp.Entities;
using DigitalWalletApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Services
{
    public class DigitallWalletService : IDigitalWalletService
    {
        public bool Deposit(DigitalWallet wallet, decimal amount)
        {
            wallet.Deposit(amount);
            return true;
        }
        public bool Withdraw(DigitalWallet wallet, decimal amount)
        {
            wallet.Withdraw(amount);
            return true;
        }
        public decimal CheckBalance(DigitalWallet wallet)
        {
           return wallet.Balance;
        }
        public List<string> GetTransactionLog(DigitalWallet wallet)
        {
            if (wallet.TransactionsLog.Count == 0)
            {
                return new List<string> { "No transactions found." };
            }
            else
            {
                List<string> Transactions = new List<string>();
                foreach (var transaction in wallet.TransactionsLog)
                {
                    Transactions.Add(transaction.ToString());
                }
                return Transactions;
            }
        }
    }
}
