using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Interfaces
{
    public interface IUserService
    {
        void Register(string name, string email);
        void Edit(Guid id, string newName, string newEmail);
        void Delete(Guid id);
        IEnumerable<User> GetAll();

        void Subscribe(Guid userId, Guid categoryId);
        void Unsubscribe(Guid userId, Guid categoryId);
    }
}
