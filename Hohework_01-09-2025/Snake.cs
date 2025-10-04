using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hohework_01_09_2025
{
    public class Snake : Animal
    {
        public Snake(string name, int age) : base(name, age)
        {
        }
        public override string Sound()
        {
            return "Hiss Hiss";
        }
        public override string Walk()
        {
            return "Snake is slithering";
        }
    }
}
