using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAcount
    {
        public int AcountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAcount(int acountNumber, string accountHolder, double initialBalance)
        {
            AcountNumber = acountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        
    }
}
