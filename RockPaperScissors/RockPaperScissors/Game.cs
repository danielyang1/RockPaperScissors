using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        Player player1 = new Player();
        Player2 player2 = new Player2();
        Computer computer = new Computer();
        Compare whoWon = new Compare();
        string playerOneName;
        string playerTwoName;
        int goal=1;

        public void gameTime1vsComp()
        {
            Console.WriteLine("Enter your name:");
            playerOneName = player1.playersname();
            Console.WriteLine("Name of Player 1: {0}", playerOneName);

            while (goal <= 10)

            {
                int player1Choice = Convert.ToInt32(player1.getPlayerChoice());
                int compChoice = computer.getComputerChoice();
                whoWon.calculateWinnerOfRoundvsComp(player1Choice, compChoice);
                Console.WriteLine("*Round: {0} *",goal);
                Console.WriteLine("{0}'s Score: {1}",playerOneName, whoWon.win);
                Console.WriteLine("Computer's Score: {0}",whoWon.lose);
                goal++;
            }
            //file.WriteLine(playerOneName, whoWon.win);
            //file.WriteLine("Computer", whoWon.lose);
           
            if (whoWon.win == whoWon.lose)
            {
                Console.WriteLine("*You Tied with the Computer!*");
            }
            else if (whoWon.win > whoWon.lose)
            {                
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\score\RPSSLscore.txt", true); 
                file.WriteLine("Player:{0} | Score:{1}",playerOneName, whoWon.win);
                file.Close();
                Console.WriteLine("*{0} Wins!*",playerOneName);
            }
            else if (whoWon.win < whoWon.lose)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\score\RPSSLscore.txt", true);
                file.WriteLine("Player:Computer | Score:"+ whoWon.lose);
                file.Close();
                Console.WriteLine("*Computer wins!*");
            }
            else
            {
                Console.WriteLine("Error: Someone was supposed to win");
            }


            //string text = System.IO.File.ReadAllText(@"C:\Users\Dan\Documents\dcc projects\RockPaperScissors\RockPaperScissors\Score\RPSSLscore.txt");
        }

        public void gameTime1vs1()
        {
            Console.WriteLine("Enter Player 1 name:");
            playerOneName = player1.playersname();
            Console.WriteLine("Enter Player 2 Name:");
            playerTwoName = player2.playersname();
            Console.WriteLine("Name of Player 1: {0}", playerOneName);
            Console.WriteLine("Name of Player 2: {0}", playerTwoName);

            while (goal <= 10)

            {
                int playerOneChoice = Convert.ToInt32(player1.getPlayerChoice());
                int playerTwoChoice = Convert.ToInt32(player1.getPlayerChoice());
                whoWon.calculateWinnerOfRoundvsPlayer2(playerOneChoice, playerTwoChoice);
                Console.WriteLine("*Round: {0} *", goal);
                Console.WriteLine("{0}'s Score: {1}", playerOneName, whoWon.win);
                Console.WriteLine("{0}'s Score: {1}", playerTwoName, whoWon.lose);
                goal++;
            }
            if (whoWon.win == whoWon.lose)
            {
                Console.WriteLine("*You Tied with {0*}", playerTwoName);
            }
            else if (whoWon.win > whoWon.lose)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\score\RPSSLscore.txt", true);
                file.WriteLine("Player:{0} | Score:{1}", playerOneName, whoWon.win);
                file.Close();
                Console.WriteLine("*{0} Wins!*", playerOneName);
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\score\RPSSLscore.txt", true);
                file.WriteLine("Player:{0} | Score:{1}", playerTwoName, whoWon.lose);
                file.Close();
                Console.WriteLine("*{0} Wins!*", playerTwoName);
            }
        }
    }
}
