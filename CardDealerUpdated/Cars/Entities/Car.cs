using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars.Entities
{
    public class Car : Vehicle
    {
        public FuelType FuelType { get; }

        public Car(Brand brand, string model, int year, double price, FuelType fuelType)
            : base(brand, model, year, price)
        {
            FuelType = fuelType;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Price}$, Fuel: {FuelType.Type}";
        }
    }
}
