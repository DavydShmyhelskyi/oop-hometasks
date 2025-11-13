using System;
using System.Threading;

namespace CoffeMachine
{
    public class CoffeMachineService : ICoffeMachineService
    {
        // Температури
        private const int RequiredWaterTemp = 90;
        private const int RequiredMilkTemp = 80;
        private const int HeatedWaterTemp = 100;
        private const int HeatedMilkTemp = 80;

        // Час нагріву
        private const int HeatingDelayMs = 2000;

        // Кількість для помелу
        private const int BeansForOnePortion = 20;

        // Рівні поповнення
        private const int RefillWaterAmount = 2000;
        private const int RefillBeansAmount = 400;
        private const int RefillMilkAmount = 600;

        private const int DefaultWaterTemp = 25;
        private const int DefaultMilkTemp = 15;


        public bool IsWaterHeated(CoffeMachine coffeMachine)
        {
            if (coffeMachine.WaterTemperature >= RequiredWaterTemp)
                return true;

            Console.WriteLine("Water is not heated enough to make coffee.");
            return false;
        }

        public bool IsMilkHeated(CoffeMachine coffeMachine)
        {
            if (coffeMachine.MilkTemperature >= RequiredMilkTemp)
                return true;

            Console.WriteLine("Milk is not heated enough to make coffee.");
            return false;
        }

        public bool IsEhoughBeans(CoffeMachine coffeMachine, int neededAmount)
        {
            if (coffeMachine.CoffeeBeansInGrams >= neededAmount)
                return true;

            Console.WriteLine("Not enough beans to make coffee.");
            return false;
        }

        public bool IsEhoughWater(CoffeMachine coffeMachine, int neededAmount)
        {
            if (coffeMachine.WaterAmountInMl >= neededAmount)
                return true;

            Console.WriteLine("Not enough water to make coffee.");
            return false;
        }

        public bool IsEnoughMilk(CoffeMachine coffeMachine, int neededAmount)
        {
            if (coffeMachine.MilkInMl >= neededAmount)
                return true;

            Console.WriteLine("Not enough milk to make coffee.");
            return false;
        }

        public int HeatWater(CoffeMachine coffeMachine)
        {
            Console.WriteLine("Heating water...");
            Thread.Sleep(HeatingDelayMs);

            coffeMachine.WaterTemperature = HeatedWaterTemp;
            Console.WriteLine($"Water heated to {HeatedWaterTemp}°C.");

            return coffeMachine.WaterTemperature;
        }

        public int HeatMilk(CoffeMachine coffeMachine)
        {
            Console.WriteLine("Heating milk...");
            Thread.Sleep(HeatingDelayMs);

            coffeMachine.MilkTemperature = HeatedMilkTemp;
            Console.WriteLine($"Milk heated to {HeatedMilkTemp}°C.");

            return coffeMachine.MilkTemperature;
        }

        public int GrindBeans(CoffeMachine coffeMachine, int neededAmount)
        {
            if (!IsEhoughBeans(coffeMachine, neededAmount))
                return coffeMachine.CoffeeBeansInGrams;

            coffeMachine.CoffeeBeansInGrams -= BeansForOnePortion;
            return coffeMachine.CoffeeBeansInGrams;
        }

        public int PourMilk(CoffeMachine coffeMachine, int neededAmount)
        {
            if (!IsEnoughMilk(coffeMachine, neededAmount))
                return coffeMachine.MilkInMl;

            coffeMachine.MilkInMl -= neededAmount;
            return coffeMachine.MilkInMl;
        }

        public int PourWater(CoffeMachine coffeMachine, int neededAmount)
        {
            if (!IsEhoughWater(coffeMachine, neededAmount))
                return coffeMachine.WaterAmountInMl;

            coffeMachine.WaterAmountInMl -= neededAmount;
            return coffeMachine.WaterAmountInMl;
        }

        public void ShowStatus(CoffeMachine coffeMachine)
        {
            Console.WriteLine($"Brand: {coffeMachine.Brand}");
            Console.WriteLine($"Water Amount: {coffeMachine.WaterAmountInMl} ml");
            Console.WriteLine($"Coffee Beans: {coffeMachine.CoffeeBeansInGrams} grams");
            Console.WriteLine($"Milk Amount: {coffeMachine.MilkInMl} ml");
            Console.WriteLine($"Water Temperature: {coffeMachine.WaterTemperature} °C");
            Console.WriteLine($"Milk Temperature: {coffeMachine.MilkTemperature} °C");
        }

        public void RefillIngredients(CoffeMachine coffeMachine)
        {
            coffeMachine.WaterAmountInMl = RefillWaterAmount;
            coffeMachine.CoffeeBeansInGrams = RefillBeansAmount;
            coffeMachine.MilkInMl = RefillMilkAmount;

            coffeMachine.WaterTemperature = DefaultWaterTemp;
            coffeMachine.MilkTemperature = DefaultMilkTemp;

            Console.WriteLine("Ingredients refilled.");
        }
    }
}
