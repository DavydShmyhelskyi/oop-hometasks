
    // 1. Command
    public interface IOrderCommand
    {
        void Execute();
    }

    // 2. Receiver 
    public class Chef
    {
        public void CookPizza() => Console.WriteLine(" Готується піца...");
        public void CookPasta() => Console.WriteLine(" Готується паста...");
    }

    // 3. Concrete Commands 
    public class PizzaOrder : IOrderCommand
    {
        private readonly Chef _chef;
        public PizzaOrder(Chef chef) => _chef = chef;

        public void Execute() => _chef.CookPizza();
    }

    public class PastaOrder : IOrderCommand
    {
        private readonly Chef _chef;
        public PastaOrder(Chef chef) => _chef = chef;

        public void Execute() => _chef.CookPasta();
    }

    // 4. Invoker 
    public class Waiter
    {
        private IOrderCommand _order;

        public void TakeOrder(IOrderCommand order)
        {
            _order = order; 
        }

        public void SendToKitchen()
        {
            _order.Execute(); 
        }
    }
