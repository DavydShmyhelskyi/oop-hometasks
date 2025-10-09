using CardDealerUpdated.Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars
{
    public interface IInventory
    {
        void AddCar(Car car);
        void RemoveCar(Car car);
        List<Car> GetAllCars();
        List<Car> SearchByBrand(string brand);
    }
}
