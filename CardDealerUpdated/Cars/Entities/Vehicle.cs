using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars.Entities
{
    public abstract class Vehicle
    {
        public Brand Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public double Price { get; }

        protected Vehicle(Brand brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
    }
}
