using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars.Entities
{
    public class Brand
    {
        public string Name { get; }

        public Brand(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}
