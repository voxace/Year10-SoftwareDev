using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "1";
            while (choice == "1")
            {
                // FOR Loop
                Console.WriteLine("FOR Loop: ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // WHILE Loop
                Console.WriteLine("\nWHILE Loop:");
                int j = 1;
                while (j <= 10)
                {
                    Console.WriteLine(j);
                    j++;
                }

                // Ask to go again
                Console.WriteLine("\nPress 1 to go again. 2 to exit.");
                choice = Console.ReadLine();
            }
        }
    }
}
