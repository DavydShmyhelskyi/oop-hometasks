using DigitalWalletApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Interfaces
{
    public interface IloginProvider
    {
        public bool ValidateLogin(User user, DigitalWallet wallet, string login, string password);
    }
}
