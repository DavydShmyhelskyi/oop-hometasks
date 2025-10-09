using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class MetalChairFactory : IChairFactory
    {
        public IChair CreateChairType1()
        {
            return new MetalChairWithFootRest();
        }   
        public IChair CreateChairType2()
        {
            return new MetalChairWithoutFootRest();
        }
    }
}
