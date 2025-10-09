using ChairFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairFabric
{
    public class ChairConveyor
    {
        public void BuildChairs(IChairFactory factory)
        {
            Console.WriteLine("Оберіть тип (1 або 2):");
            string choice = Console.ReadLine();

            IChair chair = choice == "1"
                ? factory.CreateChairType1()
                : factory.CreateChairType2();

            chair.CreateChair();
        }
    }
}
