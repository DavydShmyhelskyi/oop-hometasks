using Observer.Interfaces;

namespace Observer
{
    public class Brand : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private readonly string name;

        public Brand(string name)
        {
            this.name = name;
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string product)
        {
            foreach (var observer in observers)
            {
                observer.Update(name, product);
            }
        }

        public void ReleaseProduct(string product)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{name} have new product: {product}");
            Console.ResetColor();
            Notify(product);
        }
    }
}
