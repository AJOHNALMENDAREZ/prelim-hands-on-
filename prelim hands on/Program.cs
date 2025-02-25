using System;

public class NumberGuessingGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // Generate a random number between 1 and 10
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 10.");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            attempts++;

            if (int.TryParse(input, out guess))
            {
                if (guess < 1 || guess > 10)
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} tries!");
                     Console.WriteLine($"You ran out of guesses. The number was {secretNumber}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}



 