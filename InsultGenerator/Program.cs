using System;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Ask for your name
            string name = GetName();

            // Generate a random insult
            GenerateInsult(name, rnd);
        }

        private static string GetName()
        {
            Console.WriteLine("Welcome to the Insult Generator. What is your Name?");
            return Console.ReadLine();
        }

        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + " " 
                                + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }

        private static void Menu(string name, Random rnd)
        {
            Console.Write("Would you like another insult? y/n: ");
            if(Console.ReadLine() == "y")            {
                
                GenerateInsult(name, rnd);
            }
        }

        private static string GetAdjective(Random rnd)
        {
            string[] adjectives = {"a hairy", "an obnoxious", "a smelly", "a crusty",
                                   "an arrogant", "a funky", "a lame", "a stinky"};
            return adjectives[rnd.Next(8)];
        }

        private static string GetCompoundAdjective(Random rnd)
        {
            string[] compoundAdjectives = {"no-good", "self-loathing", "Trump-loving", "big-headed",
                                           "foul-mouthed", "cold-hearted", "pimply-faced", "rage-inducing"};
            return compoundAdjectives[rnd.Next(8)];
        }

        private static string GetObject(Random rnd)
        {
            string[] objects = {"turtle", "crab", "child", "sloth", "monkey", "stormtrooper",
                                "ice cream", "nugget", "simpleton", "lunatic", "dirtbag"};
            return objects[rnd.Next(11)];
        }
    }
}
