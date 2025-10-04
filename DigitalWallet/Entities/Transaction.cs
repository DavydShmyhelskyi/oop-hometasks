using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Entities
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Action { get; set; } // "Deposit" or "Withdrawal"

        public Transaction(string action)
        {
            Date = DateTime.Now;
            Action = action;
        }
        public override string ToString()
        {
            return $"[{Date:yyyy-MM-dd HH:mm}] {Action}";
        }

    }
}
