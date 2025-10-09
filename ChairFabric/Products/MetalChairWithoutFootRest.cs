using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class MetalChairWithoutFootRest : IChair
    {
        public string CreateChair()
        {
            return "Metal Chair without Foot Rest";
        }
    }
    
}
