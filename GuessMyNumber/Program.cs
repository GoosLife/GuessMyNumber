Random rng = new Random();

int number = rng.Next(1, 101);
int numberOfGuesses = 0;
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
        numberOfGuesses++;
        GiveHint(output, number, numberOfGuesses);
    }

    return output;
}

static void GiveHint(int guess, int number, int numberOfGuesses)
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
        GiveFeedback(numberOfGuesses);
    }
}

static void GiveFeedback(int numberOfGuesses)
{
    if (numberOfGuesses < 5)
    {
        Console.WriteLine($"You only used {numberOfGuesses} guesses. Well done!");
    }
    else if (numberOfGuesses >= 5 && numberOfGuesses < 10)
    {
        Console.WriteLine($"You used {numberOfGuesses} guesses. Not bad.");
    }
    else if (numberOfGuesses >= 10)
    {
        Console.WriteLine($"You used {numberOfGuesses}. With a little luck, I think you could improve this score!\n\nHint: You can guess a number between 1 and 100 in max 7 guesses. Try guessing 50 first.");
    }
}