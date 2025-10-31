using Observer.Interfaces;

namespace Observer
{
    public class Shop : IObserver
    {
        private readonly string name;

        public Shop(string name)
        {
            this.name = name;
        }

        public void Update(string shopName, string product)
        {
            Console.WriteLine($"{name} have update: {shopName} - {product}");
        }
    }
}
