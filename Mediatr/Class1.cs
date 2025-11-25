// Mediator
public interface IControlTower
{
    void Notify(string message, Aircraft aircraft);
}

// Concrete Mediator
public class ControlTower : IControlTower
{
    private readonly List<Aircraft> _aircrafts = new();

    public void Register(Aircraft aircraft)
    {
        _aircrafts.Add(aircraft);
    }

    public void Notify(string message, Aircraft sender)
    {
        foreach (var plane in _aircrafts)
        {
            if (plane != sender)
                plane.Receive(message);
        }
    }
}

// Colleague
public class Aircraft
{
    private readonly IControlTower _tower;
    public string Name { get; }

    public Aircraft(string name, IControlTower tower)
    {
        Name = name;
        _tower = tower;
    }

    public void Send(string message)
    {
        Console.WriteLine($"{Name}: {message}");
        _tower.Notify(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} отримав повідомлення: {message}");
    }
}
