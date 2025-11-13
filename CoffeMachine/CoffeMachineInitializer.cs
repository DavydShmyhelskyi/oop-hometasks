namespace CoffeMachine
{
    public static class CoffeeMachineInitializer
    {
        private static readonly int waterTankCapacity = 1000;
        private static readonly int coffeeBeansCapacity = 500;
        private static readonly int milkTankCapacity = 800;

        public static CoffeMachine CreateDefault()
        {
            return new CoffeMachine("Saturn", waterTankCapacity, coffeeBeansCapacity, milkTankCapacity);
        }
    }
}
