using System;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please enter your age:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            // Calculation
            int age = DateTime.Today.Year - birthday.Year;

            // Selection
            if (age >= 0 && age < 13)
            {
                Console.WriteLine("You are a child!");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager!");
            }
            else if(age >= 18)
            {
                Console.WriteLine("You are an adult!");
            }
            else
            {
                Console.WriteLine("You are not born yet!");
            }

            // Wait
            Console.ReadLine();
        }
    }
}
