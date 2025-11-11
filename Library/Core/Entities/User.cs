using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Category> Subscriptions { get; } = new();

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Subscribe(Category category)
        {
            if (!Subscriptions.Contains(category))
                Subscriptions.Add(category);
        }

        public void Unsubscribe(Category category)
        {
            Subscriptions.Remove(category);
        }

        public override string ToString() => $"{Name} ({Email})";
    }
}
