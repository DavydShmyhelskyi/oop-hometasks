// See https://aka.ms/new-console-template for more information
using ChairFabric;
using ChairFabric.Factories;
using ChairFabric.Interfaces;

Console.WriteLine("Hello, World!");
Console.WriteLine("Оберіть фабрику: 1 - Дерев'яна, 2 - Залізна, 3 - Пластикова");
string input = Console.ReadLine();

IChairFactory factory = input switch
{
    "1" => new WoodenChairFactory(),
    "2" => new MetalChairFactory(),
    _ => new PlasticChairFactory() 
};

ChairConveyor conveyor = new ChairConveyor();
conveyor.BuildChairs(factory);