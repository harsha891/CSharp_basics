using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rock-Paper-Scissors Game
            Console.WriteLine("Welcome to Rock-Paper-Scissors Game");
            Random rnd = new Random();
            string computerChoice = "";

            switch(rnd.Next(1, 3))
            {
                case 1:
                    computerChoice = "rock";
                    break;
                case 2:
                    computerChoice = "paper";
                    break;
                case 3:
                    computerChoice = "scissors";
                    break;
            }

            Console.Write("\n\trock" +
                "\n\tpaper" +
                "\n\tscissors" +
                "\nEnter your Choice: ");
            string playerChoice = Console.ReadLine().ToLower();
            do {
                if (playerChoice.Equals("rock") || playerChoice.Equals("paper") || playerChoice.Equals("scissors"))
                    break;
                Console.Write("Enter Correct choice: ");
                playerChoice = Console.ReadLine().ToLower();
            } while (true);

            Console.WriteLine("\nComputer Choice: " + computerChoice);
            Console.WriteLine("Player Choice: " + playerChoice);
            Console.WriteLine();
            if (computerChoice.Equals(playerChoice))
                Console.WriteLine("The game is draw.");
            else if (computerChoice.Equals("rock"))
            {
                if (playerChoice.Equals("paper"))
                {
                    Console.WriteLine("Player Wins");
                }
                else if (playerChoice.Equals("scissors"))
                {
                    Console.WriteLine("Computer Wins");
                }
            }
            else if(computerChoice.Equals("paper"))
            {
                if (playerChoice.Equals("scissors"))
                {
                    Console.WriteLine("Player Wins");
                }
                else if (playerChoice.Equals("rock"))
                {
                    Console.WriteLine("Computer Wins");
                }
            }

            else if (computerChoice.Equals("scissors"))
            {
                if (playerChoice.Equals("rock"))
                {
                    Console.WriteLine("Player Wins");
                }
                else if (playerChoice.Equals("paper"))
                {
                    Console.WriteLine("Computer Wins");
                }
            }
        }
    }
}
