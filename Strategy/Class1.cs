// Strategy
public interface ITransportStrategy
{
    void GoToAirport();
}

// Concrete Strategies
public class BusStrategy : ITransportStrategy
{
    public void GoToAirport() => Console.WriteLine("Їду автобусом");
}

public class TaxiStrategy : ITransportStrategy
{
    public void GoToAirport() => Console.WriteLine("Їду таксі");
}

public class BikeStrategy : ITransportStrategy
{
    public void GoToAirport() => Console.WriteLine("Їду велосипедом");
}

// Context
public class Traveler
{
    private ITransportStrategy _strategy;

    public void SetStrategy(ITransportStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Travel()
    {
        _strategy.GoToAirport();
    }
}
