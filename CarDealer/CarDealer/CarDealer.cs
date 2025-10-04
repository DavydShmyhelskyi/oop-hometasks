using CarDealer.Accounts;
using CarDealer.Cars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDealer.CarDealer
{
    public class CarDealers : ICarDealer
    {
        public string Name { get; set; }
        public ShopInventory Inventory { get; set; }
        public CurrentAccount Account { get; set; }
        private double MarkupPercent { get; set; } = 0;

        public CarDealers(string name, double initialBalance = 0)
        {
            Name = name;
            Inventory = new ShopInventory(name + " Inventory");
            Account = new CurrentAccount(initialBalance);
        }

        public void SetMarkup(double percent)
        {
            MarkupPercent = percent;
        }

        public void BuyCar(Car car, double price)
        {
            double finalPrice = car.Price + car.Price * (MarkupPercent / 100);
            if (Account.WithdrawMoney(finalPrice))
            {
                Inventory.AddCar(car);
                Console.WriteLine($"You bought {car.Brand.Name} {car.Model} for {finalPrice}$");
            }
            else
            {
                Console.WriteLine("Not enough funds to buy this car.");
            }
        }

        public void SellCar(Car car)
        {
            double price = car.Price;
            Inventory.RemoveCar(car);
            Account.AddMoney(price);
            Console.WriteLine($"{Name} sold {car.Brand.Name} {car.Model} for {price}$");
        }

        public List<Car> SearchCar(string model)
        {
            return Inventory.Cars
                .Where(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<Car> SearchCarByBrand(string brand)
        {
            return Inventory.Cars
                .Where(c => c.Brand.Name.Equals(brand, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void ExchangeCar(Car myCar, Car otherCar, ShopInventory otherInventory)
        {
            if (myCar.Price >= otherCar.Price)
            {
                Inventory.RemoveCar(myCar);
                otherInventory.RemoveCar(otherCar);

                Inventory.AddCar(otherCar);
                otherInventory.AddCar(myCar);

                Console.WriteLine($"Exchange done: {myCar.Model} <-> {otherCar.Model}");
            }
            else
            {
                double difference = otherCar.Price - myCar.Price;
                if (Account.WithdrawMoney(difference))
                {
                    Inventory.RemoveCar(myCar);
                    otherInventory.RemoveCar(otherCar);

                    Inventory.AddCar(otherCar);
                    otherInventory.AddCar(myCar);

                    Console.WriteLine($"Exchange done with extra {difference}$ paid: {myCar.Model} <-> {otherCar.Model}");
                }
                else
                {
                    Console.WriteLine("Not enough funds for exchange compensation.");
                }
            }
        }
    }
}