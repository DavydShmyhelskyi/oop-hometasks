using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWalletApp.Entities;

namespace DigitalWalletApp.Services
{
    public static class UserInitializer
    {
        public static User CreateDefault()
        {
            return new User("David", DateTime.Parse("2006-05-04"), "shmyhelskyidavid58@gmail.com", "+380991899466", "123");
        }
    }
}
