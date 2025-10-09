using DigitalWalletApp.Entities;
using DigitalWalletApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Repositories
{
    public class CsvTransactionRepository : ITransactionRepository
    {
        public void SaveTransaction(DigitalWallet wallet, string transactionText)
        {
            string path = $"{wallet.User.Name}_transactions.csv";
            File.AppendAllText(path, $"{transactionText}\n");
        }
    }
}
