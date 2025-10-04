using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Cars
{
    public class Brand
    {
        int id;
        public string Name { get; set; }
        public Brand(string name)
        {
            id++;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
