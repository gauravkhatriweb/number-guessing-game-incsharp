using System;

namespace number_guessing_game_incsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Random class to generate random numbers
            Random random = new Random();

            // Boolean to determine if the game should continue
            bool playAgain = true;

            // Define the minimum and maximum range for the random number
            int min = 1;
            int max = 100;

            // Variables to store the player's guess, the random number, and the number of guesses
            int guess;
            int number;
            int guesses;

            // Variable to store the player's response for playing again
            string response;

            // Main game loop
            while (playAgain)
            {
                // Initialize guess and guesses for the new round
                guess = 0;
                guesses = 0;
                response = "";

                // Generate a random number between min and max (inclusive)
                number = random.Next(min, max + 1);

                // Loop until the player guesses the correct number
                while (guess != number)
                {
                    // Prompt the player to make a guess
                    Console.WriteLine($"Guess a number between {min} and {max}: ");

                    // Read the player's guess and convert it to an integer
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    // Provide feedback on the player's guess
                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }

                    // Increment the number of guesses
                    guesses++;
                }

                // Output the correct number and the total number of guesses
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("You win!");
                Console.WriteLine($"Guesses: {guesses}");

                // Ask the player if they want to play again
                Console.WriteLine("Would you like to play again (Y/N):");
                response = Console.ReadLine();

                // Convert the response to uppercase for comparison
                response = response.ToUpper();

                // Determine whether to play again based on the response
                if (response != "Y")
                {
                    playAgain = false;
                }
            }

            // Final message after the game ends
            Console.WriteLine("Thanks for playing!....... I guess");
            
        }
    }
}

// Made by Gaurav Khatri with love from Pakistan
