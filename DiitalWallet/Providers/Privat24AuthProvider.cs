using Wallet.Interfaces;

namespace Wallet.Providers
{
    public class Privat24AuthProvider : ILoginProvider
    {
        private readonly string _phone;
        private readonly string _hashPassword;

        public Privat24AuthProvider(string phone, string password)
        {
            _phone = phone;
            _hashPassword = password;
        }

        public bool Validate(string login, string password)
        {
            string phonePattern = @"^\+38\d{10}$";
            return login == _phone && BCrypt.Net.BCrypt.HashPassword(password) == _hashPassword && login.StartsWith($"{phonePattern}");
        }
    }
}
