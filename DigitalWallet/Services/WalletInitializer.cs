using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletApp.Entities;

namespace DigitalWalletApp.Services
{
    public static class WalletInitializer
    {
        public static DigitalWallet CreateDefault(User user)
        {
            return new DigitalWallet("321", user);
        }
    }
}
