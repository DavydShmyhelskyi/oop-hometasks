namespace Wallet.Interfaces
{
    public interface ILoginProvider
    {
        bool Validate(string login, string password);
    }
}
