using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                // Menu
                Console.Clear();
                Console.WriteLine("Choose an Option:");
                Console.WriteLine("1. Area of Rectangle");
                Console.WriteLine("2. Area of Triangle");
                Console.WriteLine("3. Area of Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if(choice == "1")
                {
                    // Area of Rectangle
                    Console.WriteLine();
                    Console.Write("Width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (width * length));
                }
                else if(choice == "2")
                {
                    // Area of Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (0.5 * width * height));
                }
                else if(choice == "3")
                {
                    // Area of Circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Math.PI * radius * radius));
                }

                // Wait
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
