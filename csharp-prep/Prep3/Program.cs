using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        do
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 11);

            int guess = -1;
            int guessAmount = 0;

            while (guess != magicNum)
            {
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guessAmount++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }

                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }

                if (guess == magicNum)
                {
                    Console.WriteLine($"You got it in {guessAmount} guesses!");
                    Console.Write("Do you want to play again? (y/n)");
                    playAgain = Console.ReadLine();
                }

            }
        } while (playAgain == "y");
    }
}