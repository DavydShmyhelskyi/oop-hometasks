using System.Collections.Generic;

namespace Wallet.Interfaces
{
    public interface IDigitalWallet
    {
        void SetAuthProvider(ILoginProvider authProvider);
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        decimal CheckBalance();
        List<string> GetTransactionLog();
    }

}