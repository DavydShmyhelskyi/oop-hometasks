using CoffeMachine;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to CoffeeMachine!");

// Створення кавової машини через CoffeeMachineInitializer
var coffeeMachine = CoffeeMachineInitializer.CreateDefault();
var service = new MakeCoffeService();

Console.WriteLine($"Coffee machine initialized: {coffeeMachine.Brand}\n");
service.ShowStatus(coffeeMachine);

Console.WriteLine("\nChoose mode: 1 - User, 2 - Developer\n");
string mode = Console.ReadLine();
bool isDeveloper = mode == "2";

while (true)
{
    Console.WriteLine("\n--- Coffee Machine Menu ---");
    Console.WriteLine("1. Make Espresso");
    Console.WriteLine("2. Make Latte");
    Console.WriteLine("3. Show Status");
    Console.WriteLine("4. Refill Ingredients (to maximum)");
    Console.WriteLine("5. Exit");
    Console.Write("Choose option: ");
    string option = Console.ReadLine();
    Console.WriteLine();

    switch (option)
    {
        case "1":
            service.MakeEspresso(coffeeMachine);
            if (isDeveloper)
                service.ShowStatus(coffeeMachine);
            break;
        case "2":
            service.MakeLatte(coffeeMachine);
            if (isDeveloper)
                service.ShowStatus(coffeeMachine);
            break;
        case "3":
            service.ShowStatus(coffeeMachine);
            break;
        case "4":
            service.RefillIngredients(coffeeMachine);
            service.ShowStatus(coffeeMachine);
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}