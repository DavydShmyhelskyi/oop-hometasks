using CoffeMachine;

namespace CoffeMachine
{
    public static class CoffeeMachineInitializer
    {
        public static CoffeMachine CreateDefault()
        {
            return new CoffeMachine("Saturn", 2000, 400, 600);
        }
    }
}