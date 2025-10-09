using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class PlasticChairFactory: IChairFactory
    {
        public IChair CreateChairType1() => new PlasticChair();
        public IChair CreateChairType2() => new PlasticChair();
    }
}
