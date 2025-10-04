public interface IDiscountStrategy
{
    double CalculateDiscount(double price);
}

public class NewYearDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double price)
    {
        return price * 0.8;
    }
}

public class DiscountCalculator
{
    private IDiscountStrategy discountStrategy;

    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        this.discountStrategy = discountStrategy;
    }

    public double Discount(double price)
    {
        return discountStrategy.CalculateDiscount(price);
    }
}


public class DiscountCalculatorDelegate
{
    private readonly Func<double, double> discountStrategy;

    public DiscountCalculatorDelegate(Func<double, double> discountStrategy)
    {
        this.discountStrategy = discountStrategy;
    }

    public double Discount(double price)
    {
        return discountStrategy(price);
    }
}

public static class DiscountStrategiesDelegate
{
    public static double NewYear(double price) => price * 0.8;       
}

internal class Program
{
    static void Main(string[] args)
    {
        var calc = new DiscountCalculatorDelegate(DiscountStrategiesDelegate.NewYear);
        double finalPrice = calc.Discount(1000);

        Console.WriteLine(finalPrice);


        /*var calc = new DiscountCalculator(new NewYearDiscountStrategy());
        double finalPrice = calc.Discount(1000);
        Console.WriteLine(finalPrice);*/
    }
}