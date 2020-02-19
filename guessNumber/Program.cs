using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Hello there! Please enter an integer between 2 and 10"); // Ask user to enter int b/t 2 and 10
            string userGuess; // Variable for user answer
            userGuess = Console.ReadLine(); // Applies user answer and variable
            int guess;
            guess = Convert.ToInt32(userGuess); // Converts string to int
            int i; // Create variable for loop

            if (guess >=2 && guess <=10 && guess%2 == 1) // If user answer is valid, divide by two. If remainder is one...
            {
                for (i = 1; i <= guess-1; i++)
                {
                    Console.WriteLine("You entered an odd number"); // Display line 'user number' of times minus 1 (ex. user enters 7, display 6x)
                }
            }
            else if (guess >= 2 && guess <=10 && guess%2 == 0) // If user answer if valid, divide by two. If remainder is zero...
            {
                for (i = 1; i <= guess+1; i++)
                {
                    Console.WriteLine("You entered an even number"); // Display line 'user number' of times plus 1 (ex. user enters 4, display 5x)
                }
            }
            else
            {
                Console.WriteLine("Invalid integer, please try again"); // Display if user enters integer not b/t 2 and 10
            }
        }
    }
}
