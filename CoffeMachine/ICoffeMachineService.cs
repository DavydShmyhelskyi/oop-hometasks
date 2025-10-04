using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    public interface ICoffeMachineService
    {
        bool IsWaterHeated(CoffeMachine coffeMachine);
        bool IsMilkHeated(CoffeMachine coffeMachine);
        bool IsEhoughBeans(CoffeMachine coffeMachine, int neededEmount);
        bool IsEhoughWater(CoffeMachine coffeMachine, int neededEmount);
        bool IsEnoughMilk(CoffeMachine coffeMachine, int neededEmount);

        int HeatWater(CoffeMachine coffeMachine);
        int HeatMilk(CoffeMachine coffeMachine);
        int GrindBeans(CoffeMachine coffeMachine, int neededEmount);
        int PourMilk(CoffeMachine coffeMachine, int neededEmount);
        int PourWater(CoffeMachine coffeMachine, int neededEmount);
    }
}
/*
        public string Brand { get; private set; }
        public int WaterAmountInMl { get; private set; } 
        public int CoffeeBeansInGrams { get; private set; }
        public int temperature { get; private set; }
 * 
 * 
Практичне завдання: Описати клас CoffeeMachine, який матиме такі дані як: кількість води, кількість кавових зерен та чи нагріта вода для кавової машини. Зробити публічний інтерфейс доступу для читання стану кавової машини та методи, що вказані нижче. 

1 Реалізувати управління кавовою машиною через консольне меню. 
2 Клієнтський код має працювати з кавовою машиною через інтерфейс ICoffee Machine
HeatWater приватний метод, який підігріває воду
GrindBeans приватний метод, який меле вказану кількість кави та перевіряє чи її досить в кавовій машині
MakeEspresso публічний метод, якому потрібно 20 грам кавових зерен, щоб зробити порцію
MakeLatte публічний метод, якому потрібно 25 грам кавових зерен, щоб зробити порцію
*/