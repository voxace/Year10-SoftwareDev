using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.WriteLine("Please enter a number for X:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for Y:");
            float y = float.Parse(Console.ReadLine());

            // Output
            Console.WriteLine("X plus Y = " + (x + y));
            Console.WriteLine("X times Y = " + (x * y));
            Console.WriteLine("X minus Y = " + (x - y));
            Console.WriteLine("X divided by Y = " + (x / y));

            // Wait
            Console.ReadLine();
        }
    }
}
