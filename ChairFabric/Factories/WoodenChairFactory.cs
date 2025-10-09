using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class WoodenChairFactory : IChairFactory
    {
        public IChair CreateChairType1()
        {
          return new WoodenChairWithBack();
        }
        public IChair CreateChairType2()
        {
            return new WoodenChairWithoutBack();
        }
    }
}
