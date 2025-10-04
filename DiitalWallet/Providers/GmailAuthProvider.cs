using Wallet.Interfaces;

namespace Wallet.Providers
{
    public class GmailAuthProvider : ILoginProvider
    {
        private readonly string _gmail;
        private readonly string _hashPassword;

        public GmailAuthProvider(string gmail, string password)
        {
            _gmail = gmail;
            _hashPassword = DigitalWallet.PasswordHash;
        }

        public bool Validate(string login, string password)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return login == _gmail && BCrypt.Net.BCrypt.HashPassword(password) == _hashPassword && login.EndsWith($"{emailPattern}");
        }
    }
}
