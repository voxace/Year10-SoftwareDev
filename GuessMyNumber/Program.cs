using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Random Number from 1 to 100
            Random rnd = new System.Random();
            int randomNumber = rnd.Next(1, 101);

            // Set guess to number out of random range
            int guess = -1;

            // Start loop
            while (guess != randomNumber)
            {
                // Input
                guess = int.Parse(Console.ReadLine());

                // Selection
                if (guess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
            }

            // Wait
            Console.ReadLine();
        }
    }
}
