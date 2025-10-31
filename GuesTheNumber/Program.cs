Console.WriteLine("Welcome to 'Guess The Number'!");
Console.WriteLine("I'm thinking of a number between 1 and 10.");

var random = new Random();
var numberToGuess = random.Next(1, 11);
int userGuess = 0;
while (userGuess != numberToGuess)
{
    Console.Write("Enter your guess: ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out userGuess))
    {
        if (userGuess < numberToGuess)
        {
            Console.WriteLine("Too low! Try again.");
        }
        else if (userGuess > numberToGuess)
        {
            Console.WriteLine("Too high! Try again.");
        }
        else
        {
            Console.WriteLine("Congratulations! You've guessed the number!");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}