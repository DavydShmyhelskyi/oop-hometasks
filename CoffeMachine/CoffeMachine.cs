using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    public class CoffeMachine
    {
        public string Brand { get; private set; }
        public int WaterAmountInMl { get; set; } 
        public int CoffeeBeansInGrams { get; set; }
        public int WaterTemperature { get; set; }
        public int MilkInMl { get; set; }
        public int MilkTemperature { get; set; }



        public CoffeMachine(string brand, int waterAmountInMl, int coffeeBeansInGrams, int milkInMl)
        {
            Brand = brand;
            WaterAmountInMl = waterAmountInMl;
            CoffeeBeansInGrams = coffeeBeansInGrams;
            MilkInMl = milkInMl;
            WaterTemperature = 25; 
            MilkTemperature = 15;            
        }        
    }
}
/*
Практичне завдання: Описати клас CoffeeMachine, який матиме такі дані як: кількість води, кількість кавових зерен та чи нагріта вода для кавової машини. Зробити публічний інтерфейс доступу для читання стану кавової машини та методи, що вказані нижче. 

1 Реалізувати управління кавовою машиною через консольне меню. 
2 Клієнтський код має працювати з кавовою машиною через інтерфейс ICoffee Machine
HeatWater приватний метод, який підігріває воду
GrindBeans приватний метод, який меле вказану кількість кави та перевіряє чи її досить в кавовій машині
MakeEspresso публічний метод, якому потрібно 20 грам кавових зерен, щоб зробити порцію
MakeLatte публічний метод, якому потрібно 25 грам кавових зерен, щоб зробити порцію
*/