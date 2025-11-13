using System;

namespace CoffeMachine
{
    public class MakeCoffeService : CoffeMachineService
    {
        // Для еспресо
        private const int EspressoRequiredWater = 30;
        private const int EspressoRequiredBeans = 20;
        private const int EspressoWaterToPour = 50;

        // Для лате
        private const int LatteRequiredWater = 30;
        private const int LatteRequiredBeans = 25;
        private const int LatteWaterToPour = 50;
        private const int LatteMilkToPour = 100;

        public void MakeEspresso(CoffeMachine coffeMachine)
        {
            if (IsEhoughWater(coffeMachine, EspressoRequiredWater) &&
                IsEhoughBeans(coffeMachine, EspressoRequiredBeans))
            {
                if (!IsWaterHeated(coffeMachine))
                {
                    HeatWater(coffeMachine);
                }

                GrindBeans(coffeMachine, EspressoRequiredBeans);
                PourWater(coffeMachine, EspressoWaterToPour);

                Console.WriteLine("\nEspresso is ready!\n");
            }
            else
            {
                Console.WriteLine("Cannot make Espresso.");
            }
        }

        public void MakeLatte(CoffeMachine coffeMachine)
        {
            if (IsEhoughWater(coffeMachine, LatteRequiredWater) &&
                IsEhoughBeans(coffeMachine, LatteRequiredBeans))
            {
                if (!IsWaterHeated(coffeMachine))
                {
                    HeatWater(coffeMachine);
                }
                if (!IsMilkHeated(coffeMachine))
                {
                    HeatMilk(coffeMachine);
                }

                GrindBeans(coffeMachine, LatteRequiredBeans);
                PourWater(coffeMachine, LatteWaterToPour);
                PourMilk(coffeMachine, LatteMilkToPour);

                Console.WriteLine("\nLatte is ready!\n");
            }
            else
            {
                Console.WriteLine("Cannot make Latte.");
            }
        }
    }
}
