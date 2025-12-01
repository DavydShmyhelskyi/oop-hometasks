public class Government
{
    // Єдиний екземпляр
    private static Government _instance;

    // Приватний конструктор
    private Government(string countryName)
    {
        Country = countryName;
    }

    public string Country { get; }

    // Глобальна точка доступу
    public static Government GetInstance(string countryName)
    {
        if (_instance == null)
        {
            Console.WriteLine("Створюємо уряд держави...");
            _instance = new Government(countryName);
        }

        return _instance;
    }

    public void MakeDecision(string decision)
    {
        Console.WriteLine($"Уряд {Country} ухвалив рішення: {decision}");
    }
}
