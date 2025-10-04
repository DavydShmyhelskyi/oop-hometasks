using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    public class MakeCoffeService : CoffeMachineService
    {
        public void MakeEspresso(CoffeMachine coffeMachine)
        {
            if (IsEhoughWater(coffeMachine, 30) && IsEhoughBeans(coffeMachine, 20))
            {
                if (!IsWaterHeated(coffeMachine))
                {
                    HeatWater(coffeMachine);
                }
                GrindBeans(coffeMachine, 20);
                PourWater(coffeMachine, 50);
                Console.WriteLine("\nEspresso is ready!\n");
            }
            else
            {
                Console.WriteLine("Cannot make Espresso.");
            }
        }
        public void MakeLatte(CoffeMachine coffeMachine)
        {
            if (IsEhoughWater(coffeMachine, 30) && IsEhoughBeans(coffeMachine, 30))
            {
                if (!IsWaterHeated(coffeMachine))
                {
                    HeatWater(coffeMachine);
                }
                if (!IsMilkHeated(coffeMachine))
                {
                    HeatMilk(coffeMachine);
                }
                GrindBeans(coffeMachine, 20);
                PourWater(coffeMachine, 50);
                PourMilk(coffeMachine, 100);
                Console.WriteLine("\nLatte is ready!\n");
            }
            else
            {
                Console.WriteLine("Cannot make Espresso.");
            }
        }
    }

}
/*MakeEspresso публічний метод, якому потрібно 20 грам кавових зерен, щоб зробити порцію
MakeLatte публічний метод, якому потрібно 25 грам кавових зерен, щоб зробити порцію*/