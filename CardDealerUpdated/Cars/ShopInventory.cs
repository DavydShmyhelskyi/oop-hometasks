using CardDealerUpdated.Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars
{
    public class ShopInventory : IInventory
    {
        public string ShopName { get; }
        private readonly List<Car> _cars = new();

        public ShopInventory(string shopName)
        {
            ShopName = shopName;
        }

        public void AddCar(Car car) => _cars.Add(car);
        public void RemoveCar(Car car) => _cars.Remove(car);
        public List<Car> GetAllCars() => new(_cars);

        public List<Car> SearchByBrand(string brand) =>
            _cars.Where(c => c.Brand.Name.Equals(brand, System.StringComparison.OrdinalIgnoreCase)).ToList();
    }

}
