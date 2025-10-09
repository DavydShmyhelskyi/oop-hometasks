using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class WoodenChairWithBack : IChair
    {
        public string CreateChair()
        {
            return "Wooden Chair with Back";
        }
    }
}
