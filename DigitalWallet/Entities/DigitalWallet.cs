using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Entities
{
    public class DigitalWallet
    {
        public decimal Balance { get; private set; }
        public string HashPassword { get; private set; }
        public User User { get; set; }
        public List<Transaction> TransactionsLog { get; private set; } = new List<Transaction>();

        public DigitalWallet(string Password, User user)
        {
            HashPassword = BCrypt.Net.BCrypt.HashPassword(Password);
            User = user;
            Balance = 0;
        }     
        
        public decimal Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");
            Balance += amount;
            TransactionsLog.Add(new Transaction($"Deposit {amount}; Balance: {Balance}"));
            return Balance;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive.");
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");
            Balance -= amount;
            TransactionsLog.Add(new Transaction($"Withdraw {amount}; Balance: {Balance}"));
            return Balance;
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, HashPassword);
        }
    }
}
