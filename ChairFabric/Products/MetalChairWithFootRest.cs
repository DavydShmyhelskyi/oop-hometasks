using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Factories
{
    public class MetalChairWithFootRest : IChair
    {
        public string CreateChair()
        {
            return "Metal Chair with Foot Rest";
        }
    }
    
}
