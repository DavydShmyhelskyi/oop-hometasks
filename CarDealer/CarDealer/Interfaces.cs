using CarDealer.Cars;

namespace CarDealer.CarDealer
{
    public interface ICarDealer
    {
        List<Car> SearchCar(string model);
        void ExchangeCar(Car myCar, Car otherCar, ShopInventory otherInventory);
    }
}