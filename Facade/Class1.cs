// Підсистема: створення замовлення
public class OrderSystem
{
    public int CreateOrder(string productName)
    {
        Console.WriteLine($"[OrderSystem] Створено замовлення на товар: {productName}");
        return new Random().Next(1000, 9999);
    }
}

// Підсистема: оплата
public class PaymentSystem
{
    public bool Charge(string cardNumber, decimal amount)
    {
        Console.WriteLine($"[PaymentSystem] Списано {amount} грн з карти ****{cardNumber[^4..]}");
        return true;
    }
}

// Підсистема: доставка
public class DeliveryService
{
    public void ArrangeDelivery(int orderId, string address)
    {
        Console.WriteLine($"[DeliveryService] Замовлення {orderId} буде доставлено за адресою: {address}");
    }
}

// Facade: оператор служби підтримки
public class CustomerSupportFacade
{
    private readonly OrderSystem _orderSystem;
    private readonly PaymentSystem _paymentSystem;
    private readonly DeliveryService _deliveryService;

    public CustomerSupportFacade(
        OrderSystem orderSystem,
        PaymentSystem paymentSystem,
        DeliveryService deliveryService)
    {
        _orderSystem = orderSystem;
        _paymentSystem = paymentSystem;
        _deliveryService = deliveryService;
    }

    public void MakeOrder(string productName, decimal price, string cardNumber, string address)
    {
        Console.WriteLine("Оператор: оформлю для вас замовлення...");

        int orderId = _orderSystem.CreateOrder(productName);

        bool paid = _paymentSystem.Charge(cardNumber, price);
        if (!paid)
        {
            Console.WriteLine("Оператор: оплата не пройшла.");
            return;
        }

        _deliveryService.ArrangeDelivery(orderId, address);

        Console.WriteLine("Оператор: замовлення оформлено, очікуйте доставку!");
    }
}