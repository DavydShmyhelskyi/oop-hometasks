using CarDealer.CarDealer;
using CarDealer.Cars;
using System;
using System.Collections.Generic;

        CarDealers dealer = new CarDealers("AutoLux", 100000);

        var bmw = new Brand("BMW");
        var audi = new Brand("Audi");
        var tesla = new Brand("Tesla");

        var electric = new FuelType(1, "Electric");
        var hybrid = new FuelType(2, "Hybrid");
        var gasoline = new FuelType(3, "Gasoline");

        var car1 = new Car(bmw, "X5", 2020, 30000, gasoline);
        var car2 = new Car(audi, "A6", 2019, 25000, hybrid);

        dealer.Inventory.AddCar(car1);
        dealer.Inventory.AddCar(car2);

        CarDealers dealer2 = new CarDealers("EuroCars", 50000);
        dealer2.Inventory.AddCar(new Car(tesla, "Model S", 2021, 60000, electric));
        List<CarDealers> allDealers = new List<CarDealers> { dealer, dealer2 };

        Console.WriteLine("Select role: 1 - User, 2 - Admin");
        string role = Console.ReadLine();

while (true)
{
    Console.WriteLine("\n=== Car Dealer Menu ===");
    Console.WriteLine("1. Show all cars");
    Console.WriteLine("2. Search car by brand");
    Console.WriteLine("3. Buy car");
    if (role == "2")
    {
        Console.WriteLine("4. Sell car");
        Console.WriteLine("5. Set markup");
        Console.WriteLine("6. Show account balance");
        Console.WriteLine("7. Exchange car with another dealer");
    }
    Console.WriteLine("0. Exit");

    Console.Write("\nChoose option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            foreach (var c in dealer.Inventory.GetAllCars())
                Console.WriteLine(c);
            break;

        case "2":
            Console.Write("Enter brand to search: ");
            string brand = Console.ReadLine();
            foreach (var d in allDealers)
            {
                var foundCars = d.SearchCarByBrand(brand);
                if (foundCars.Count > 0)
                {
                    Console.WriteLine($"Found in {d.Name}:");
                    foundCars.ForEach(c => Console.WriteLine(c));
                }
            }
            break;

        case "3":
            if (dealer.Inventory.Cars.Count == 0)
            {
                Console.WriteLine("No cars available for purchase.");
                break;
            }
            Console.WriteLine("Choose car index to buy:");
            for (int i = 0; i < dealer.Inventory.Cars.Count; i++)
                Console.WriteLine($"{i}. {dealer.Inventory.Cars[i]}");

            if (int.TryParse(Console.ReadLine(), out int buyIndex) &&
                buyIndex >= 0 && buyIndex < dealer.Inventory.Cars.Count)
            {
                var carToBuy = dealer.Inventory.Cars[buyIndex];
                dealer.BuyCar(carToBuy, carToBuy.Price);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
            break;

        case "4":
            if (role != "2") break;
            if (dealer.Inventory.Cars.Count == 0)
            {
                Console.WriteLine("No cars to sell.");
                break;
            }
            Console.WriteLine("Choose car index to sell:");
            for (int i = 0; i < dealer.Inventory.Cars.Count; i++)
                Console.WriteLine($"{i}. {dealer.Inventory.Cars[i]}");

            if (int.TryParse(Console.ReadLine(), out int sellIndex) &&
                sellIndex >= 0 && sellIndex < dealer.Inventory.Cars.Count)
            {
                dealer.SellCar(dealer.Inventory.Cars[sellIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
            break;

        case "5":
            if (role != "2") break;
            Console.Write("Enter markup %: ");
            if (double.TryParse(Console.ReadLine(), out double percent))
                dealer.SetMarkup(percent);
            else
                Console.WriteLine("Invalid input.");
            break;

        case "6":
            if (role != "2") break;
            Console.WriteLine(dealer.Account);
            break;

        case "7":
            if (role != "2") break;
            Console.WriteLine("Your cars:");
            for (int i = 0; i < dealer.Inventory.Cars.Count; i++)
                Console.WriteLine($"{i}. {dealer.Inventory.Cars[i]}");
            Console.Write("Select your car index: ");
            if (!int.TryParse(Console.ReadLine(), out int myCarIdx) ||
                myCarIdx < 0 || myCarIdx >= dealer.Inventory.Cars.Count)
            {
                Console.WriteLine("Invalid index.");
                break;
            }
            Console.WriteLine("Select dealer to exchange with:");
            for (int i = 0; i < allDealers.Count; i++)
                if (allDealers[i] != dealer)
                    Console.WriteLine($"{i}. {allDealers[i].Name}");
            if (!int.TryParse(Console.ReadLine(), out int otherDealerIdx) ||
                otherDealerIdx < 0 || otherDealerIdx >= allDealers.Count || allDealers[otherDealerIdx] == dealer)
            {
                Console.WriteLine("Invalid dealer.");
                break;
            }
            var otherDealer = allDealers[otherDealerIdx];
            if (otherDealer.Inventory.Cars.Count == 0)
            {
                Console.WriteLine("No cars to exchange in selected dealer.");
                break;
            }
            Console.WriteLine("Their cars:");
            for (int i = 0; i < otherDealer.Inventory.Cars.Count; i++)
                Console.WriteLine($"{i}. {otherDealer.Inventory.Cars[i]}");
            Console.Write("Select their car index: ");
            if (!int.TryParse(Console.ReadLine(), out int theirCarIdx) ||
                theirCarIdx < 0 || theirCarIdx >= otherDealer.Inventory.Cars.Count)
            {
                Console.WriteLine("Invalid index.");
                break;
            }
            dealer.ExchangeCar(
                dealer.Inventory.Cars[myCarIdx],
                otherDealer.Inventory.Cars[theirCarIdx],
                otherDealer.Inventory
            );
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
}
