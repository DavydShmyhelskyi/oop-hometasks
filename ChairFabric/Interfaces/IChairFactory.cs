using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric.Interfaces
{
    public interface IChairFactory
    {
        IChair CreateChairType1();
        IChair CreateChairType2();
    }
}
