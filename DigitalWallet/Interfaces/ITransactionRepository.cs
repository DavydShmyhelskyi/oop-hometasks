using DigitalWalletApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Interfaces
{
    public interface ITransactionRepository
    {
        void SaveTransaction(DigitalWallet wallet, string action);
    }
}
