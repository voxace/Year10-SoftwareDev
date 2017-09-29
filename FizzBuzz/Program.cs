using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 100 Times
            for (int i = 1; i <= 100; i++)
            {
                // If divisible by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // If divisible by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // If divisible by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Otherwise, just print the number
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Wait
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}