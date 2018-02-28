using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from user 1 and 2 

            Console.WriteLine("Player 1, Choose Rock Paper or Scissors");
            string Player1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Player 2, Choose Rock Paper or Scissors");
            string Player2 = Console.ReadLine();

            // compare inputs

            //tie
            if (Player1 == Player2)
            {
                Console.WriteLine("It's a tie!");
            }
            //Player 1 Paper
            else if (Player1 == "Paper" && Player2 == "Rock")
            {
                Console.WriteLine("Player 1 Wins! Paper Covers Rock!");
            }
            // Player 1 Scissors
            else if (Player1 == "Scissors" && Player2 == "Paper")
            {
                Console.WriteLine("Player1 Wins! Scissors cut Paper!");
            }
            // Player 1 Rock
            else if (Player1 == "Rock" && Player2 == "Scissors")
            {
                Console.WriteLine("Player1 Wins! Rock Smashes Scissors!");
            }
            //Player 2 Wins
            else
            {
                Console.WriteLine("Player2 Wins!");
            }
            Console.ReadLine();
        }
    }
}
