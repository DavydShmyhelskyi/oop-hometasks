using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Accounts
{
    public interface IAccount
    {
        double Balance { get; }
        void AddMoney(double amount);
        bool WithdrawMoney(double amount);
    }
}
