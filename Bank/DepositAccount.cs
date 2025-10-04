using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount : BankAcount
    {
        public double InterestRate { get; set; }
        public DepositAccount(int acountNumber, string accountHolder, double initialBalance, double interestRate)
            : base(acountNumber, accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void ApplyInterest()
        {
            Balance += Balance * InterestRate / 100;
        }
    }
}
