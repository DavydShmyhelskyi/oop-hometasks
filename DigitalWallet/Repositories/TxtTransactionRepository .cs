using DigitalWalletApp.Entities;
using DigitalWalletApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Repositories
{
    public class TxtTransactionRepository : ITransactionRepository
    {
        public void SaveTransaction(DigitalWallet wallet, string action)
        {
            string path = $"{wallet.User.Name}_transactions.txt";
            File.AppendAllText(path, action + Environment.NewLine);
        }
    }
}
