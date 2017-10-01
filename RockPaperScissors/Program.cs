using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while(repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);           // Print scores
                string userChoice = UserTurn();                         // User's turn
                string computerChoice = ComputerTurn();                 // Computer's turn
                result = DetermineWinner(userChoice, computerChoice);   // Determine the winner
                GiveFeedback(result, userChoice, computerChoice);       // Provide feedback
                UpdateScores(result, ref userScore, ref computerScore); // Update the score
                repeat = PlayAgain();                                   // Ask to play again
            }            
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "     Computer: " + computerScore);
        }

        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.Write("Your Choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private static string DetermineWinner(string user, string computer)
        {
            if (user == "Rock")
            {
                if (computer == "Rock")
                {
                    return "Draw";
                }
                else if (computer == "Paper")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }
            else if (user == "Paper")
            {
                if (computer == "Rock")
                {
                    return "Win";
                }
                else if (computer == "Paper")
                {
                    return "Draw";
                }
                else
                {
                    return "Lose";
                }
            }
            else
            {
                if (computer == "Rock")
                {
                    return "Lose";
                }
                else if (computer == "Paper")
                {
                    return "Win";
                }
                else
                {
                    return "Draw";
                }
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine(result + "! The computer chose " + computerChoice + " and you chose " + userChoice);
        }

        private static bool PlayAgain()
        {
            string choice = "";
            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Play again? 1 = Yes, 2 = No");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void UpdateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else if (result == "Lose")
            {
                computerScore++;
            }
        }
    }
}