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
            string[] adjectives = {"a hairy", "an obnoxious", "a smelly", "a crusty", "a thoughtless",
                                   "an arrogant", "a funky", "a lame", "a stinky", "a vulgar",
                                   "a slimy", "a silly", "a weedy", "a warped", "an untalented" };
            return adjectives[rnd.Next(15)];
        }

        private static string GetCompoundAdjective(Random rnd)
        {
            string[] compoundAdjectives = {"no-good", "self-loathing", "Trump-loving", "big-headed",
                                           "foul-mouthed", "cold-hearted", "pimply-faced", "rage-inducing",
                                           "nerve-racking", "weird-smelling", "heavy-breathing", "self-centred",
                                           "slow-moving", "close-minded", "free-loading", "diaper-wearing"};
            return compoundAdjectives[rnd.Next(16)];
        }

        private static string GetObject(Random rnd)
        {
            string[] objects = {"turtle", "crab", "child", "sloth", "monkey", "stormtrooper",
                                "troll", "nugget", "simpleton", "lunatic", "dirtbag", "grub",
                                "snot-gobbler", "maggot", "weirdo", "rat", "dog", "nerd", "loner" };
            return objects[rnd.Next(19)];
        }
    }
}
