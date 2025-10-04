using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hohework_01_09_2025
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
        public override string Sound()
        {
            return "Woof Woof";
        }
        public override string Walk()
        {
            return "Dog is walking";
        }
    }    
}
