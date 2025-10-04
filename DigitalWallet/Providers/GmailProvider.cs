using DigitalWalletApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletApp.Interfaces;

namespace DigitalWalletApp.Providers
{
    public class GmailProvider : IloginProvider
    {
        public bool ValidateLogin(User user, DigitalWallet wallet, string login, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, wallet.HashPassword)
                   && login == user.Email
                   && user == wallet.User;
        }

    }
}
