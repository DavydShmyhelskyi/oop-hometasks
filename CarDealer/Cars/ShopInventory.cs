namespace CarDealer.Cars
{
    public class ShopInventory
    {
        public string ShopName { get; set; }
        public List<Car> Cars { get; private set; }
        public ShopInventory(string shopName)
        {
            ShopName = shopName;
            //Cars = new List<Car>();
            Cars = null;
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }
        public List<Car> SearchByBrand(string brand)
        {
            return Cars.Where(c => c.Brand.Name.Equals(brand, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Car> GetAllCars()
        {
            return Cars;
        }
    }
}