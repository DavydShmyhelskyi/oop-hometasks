using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CoffeMachine
{
    public class CoffeMachineService : ICoffeMachineService
    {
        public bool IsWaterHeated(CoffeMachine coffeMachine)
        {
            if (coffeMachine.WaterTemperature >= 90)
                return true;
            else
            {
                Console.WriteLine("Water is not heated enough to make coffee.");
                return false;
            }
        }
        public bool IsMilkHeated(CoffeMachine coffeMachine)
        {
            if (coffeMachine.MilkTemperature >= 80)
                return true;
            else
            {
                Console.WriteLine("Milk is not heated enough to make coffee.");
                return false;
            }
        }
        public bool IsEhoughBeans(CoffeMachine coffeMachine, int neededEmount)
        {
            if (coffeMachine.CoffeeBeansInGrams >= neededEmount)
                return true;
            else
            {
                Console.WriteLine("Not enough beans to make coffee.");
                return false;
            }
        }
        public bool IsEhoughWater(CoffeMachine coffeMachine, int neededEmount)
        {
            if (coffeMachine.WaterAmountInMl >= neededEmount)
            { return true; }
            else
            {
                Console.WriteLine("Not enough water to make coffee.");
                return false;
            }
        }
        public bool IsEnoughMilk(CoffeMachine coffeMachine, int neededEmount)
        {
            if (coffeMachine.MilkInMl >= neededEmount)
                return true;
            else
            {
                Console.WriteLine("Not enough milk to make coffee.");
                return false;
            }
        }

        public int HeatWater(CoffeMachine coffeMachine)
        {
            Console.WriteLine("Heating water...");
            Thread.Sleep(2000);
            coffeMachine.WaterTemperature = 100;
            Console.WriteLine("Water heated to 100°C.");
            return coffeMachine.WaterTemperature;
        }

        public int HeatMilk(CoffeMachine coffeMachine)
        {
            Console.WriteLine("Heating milk...");
            Thread.Sleep(2000);
            coffeMachine.MilkTemperature = 80;
            Console.WriteLine("Milk heated to 80°C.");
            return coffeMachine.MilkInMl;
        }
        public int GrindBeans(CoffeMachine coffeMachine, int neededEmount)
        {
            if (!IsEhoughBeans(coffeMachine, neededEmount))
            {
                Console.WriteLine("Not enough beans to make coffee.");
                return coffeMachine.CoffeeBeansInGrams;
            }
            else
            {
                coffeMachine.CoffeeBeansInGrams -= 20;
                return coffeMachine.CoffeeBeansInGrams;
            }
        }
        public int PourMilk(CoffeMachine coffeMachine, int neededEmount)
        {
            if (!IsEnoughMilk(coffeMachine, neededEmount))
            {
                Console.WriteLine("Not enough milk to make coffee.");
                return coffeMachine.MilkInMl;
            }
            else
            {
                coffeMachine.MilkInMl -= neededEmount;
                return coffeMachine.MilkInMl;
            }
        }
        public int PourWater(CoffeMachine coffeMachine, int neededEmount)
        {
            if (!IsEhoughWater(coffeMachine, neededEmount))
            {
                Console.WriteLine("Not enough water to make coffee.");
                return coffeMachine.WaterAmountInMl;
            }
            else
            {
                coffeMachine.WaterAmountInMl -= neededEmount;
                return coffeMachine.WaterAmountInMl;
            }
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
            coffeMachine.WaterAmountInMl = 2000;
            coffeMachine.CoffeeBeansInGrams = 400;
            coffeMachine.MilkInMl = 600;
            coffeMachine.WaterTemperature = 25;
            coffeMachine.MilkTemperature = 15;
            Console.WriteLine("Ingredients refilled.");
        }
    }
}