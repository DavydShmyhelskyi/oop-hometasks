using DigitalWalletApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Interfaces
{
    public interface IDigitalWalletService
    {
        bool Deposit(DigitalWallet wallet, decimal amount);
        bool Withdraw(DigitalWallet wallet, decimal amount);
        decimal CheckBalance(DigitalWallet wallet);
        List<string> GetTransactionLog(DigitalWallet wallet);
    }
}
