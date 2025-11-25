// Component
public interface IPerson
{
    void Describe();
}

// ConcreteComponent
public class Person : IPerson
{
    public void Describe()
    {
        Console.WriteLine("Це людина.");
    }
}

// Decorator
public abstract class ClothingDecorator : IPerson
{
    protected readonly IPerson _person;

    protected ClothingDecorator(IPerson person)
    {
        _person = person;
    }

    public virtual void Describe()
    {
        _person.Describe();
    }
}

// ConcreteDecorators
public class Sweater : ClothingDecorator
{
    public Sweater(IPerson person) : base(person) { }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine("Одягнуто светр.");
    }
}

public class Raincoat : ClothingDecorator
{
    public Raincoat(IPerson person) : base(person) { }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine("Одягнуто плащ.");
    }
}
