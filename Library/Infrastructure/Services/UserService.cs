using Library.Core.Entities;
using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepo;
        private readonly IRepository<Category> catRepo;

        public UserService(IRepository<User> userRepo, IRepository<Category> catRepo)
        {
            this.userRepo = userRepo;
            this.catRepo = catRepo;
        }

        public void Register(string name, string email)
            => userRepo.Add(new User(name, email));

        public void Edit(Guid id, string newName, string newEmail)
        {
            var user = userRepo.GetById(id);
            if (user == null)
                throw new ArgumentException("User not found.");

            user.Name = newName;
            user.Email = newEmail;
        }

        public void Delete(Guid id)
        {
            var user = userRepo.GetById(id);
            if (user == null)
                throw new ArgumentException("User not found.");

            userRepo.Remove(id);
        }

        public IEnumerable<User> GetAll() => userRepo.GetAll();

        public void Subscribe(Guid userId, Guid categoryId)
        {
            var user = userRepo.GetById(userId);
            if (user == null)
                throw new ArgumentException("User not found.");

            var category = catRepo.GetById(categoryId);
            if (category == null)
                throw new ArgumentException("Category does not exist.");

            user.Subscribe(category);
        }

        public void Unsubscribe(Guid userId, Guid categoryId)
        {
            var user = userRepo.GetById(userId);
            if (user == null)
                throw new ArgumentException("User not found.");

            var category = catRepo.GetById(categoryId);
            if (category == null)
                throw new ArgumentException("Category does not exist.");

            user.Unsubscribe(category);
        }
    }
}
