using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Pick a Door: 1, 2 or 3");
            string door = Console.ReadLine();

            // Selection
            if (door == "1")
            {
                Console.WriteLine("Behind door 1 is Donald Trump.");
            }
            else if (door == "2")
            {
                Console.WriteLine("Behind door 2 is a Cute Puppy");
            }
            else if (door == "3")
            {
                Console.WriteLine("Behind door 3 is a 1988 Toyota Camry.");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

            // Wait
            Console.ReadLine();
        }
    }
}
