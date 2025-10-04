using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hohework_01_09_2025
{
    public class Cat: Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override string Sound()
        {
            return"Meow Meow";
        }
        public override string Walk()
        {
            return "Cat is walking";
        }
    }
}
  
