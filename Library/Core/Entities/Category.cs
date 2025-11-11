using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Category
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }

        public Category(string name) => Name = name;

        public override string ToString() => Name;
    }
}
