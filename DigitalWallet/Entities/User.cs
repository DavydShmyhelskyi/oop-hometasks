using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletApp.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BankHashPassword { get; private set; }
        public List<DigitalWallet> Wallets { get; set; } = new List<DigitalWallet>();

        public User(string name, DateTime dateOfBirth, string email, string phoneNumber, string bankPassword)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            BankHashPassword = BCrypt.Net.BCrypt.HashPassword(bankPassword);
        }

        public bool VerifyBankPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, BankHashPassword);
        }

    }
}
