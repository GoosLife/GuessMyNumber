Random rng = new Random();

int number = rng.Next(1, 101);
int guess;

Console.WriteLine("Guess my number! (1-100).");

do
{
    guess = Guess();
} while (guess != number);

int Guess()
{
    string input;
    int output;

    input = Console.ReadLine();
    if (!int.TryParse(input, out output))
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
    }
    else
    {
        // Outputs feedback to the users guess (a hint, or confirmation that the guess was correct).
        GiveFeedback(output, number);
    }

    return output;
}

static void GiveFeedback(int guess, int number)
{
    if (guess > number)
    {
        Console.WriteLine("My number is smaller.");
    }
    else if (guess < number)
    {
        Console.WriteLine("My number is larger.");
    }
    else if (guess == number)
    {
        Console.WriteLine("Correct! My number was {0}", number);
    }
}