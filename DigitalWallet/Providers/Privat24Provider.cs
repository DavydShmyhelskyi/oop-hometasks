using DigitalWalletApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletApp.Interfaces;

namespace DigitalWalletApp.Providers
{
    public class Privat24Provider : IloginProvider
    {
        public bool ValidateLogin(User user, DigitalWallet wallet, string login, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, user.BankHashPassword)
                   && login == user.PhoneNumber
                   && user == wallet.User;
        }

    }
}
