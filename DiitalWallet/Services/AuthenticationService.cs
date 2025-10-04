using Wallet.Interfaces;

namespace DigitalWalletApp.Services
{
    public class AuthenticationService
    {
        private readonly ILoginProvider _provider;
        private bool _isAuthenticated;

        public AuthenticationService(ILoginProvider provider)
        {
            _provider = provider;
        }

        public void Authenticate(string login, string password)
        {
            if (!_provider.Validate(login, password))
                throw new UnauthorizedAccessException("Invalid credentials");

            _isAuthenticated = true;
        }

        public void EnsureAuthenticated()
        {
            if (!_isAuthenticated)
                throw new UnauthorizedAccessException("You must login first");
        }
    }
}
