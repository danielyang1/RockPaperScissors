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
        int goal;

        public void gameTime1vsComp()
        {
            Console.WriteLine("Enter your name.");
            playerOneName = player1.playersname();
            Console.WriteLine("Name of Player 1: {0}", playerOneName);

            while (goal <= 10)

            {
                int player1Choice = Convert.ToInt32(player1.getPlayerChoice());
                int compChoice = computer.getComputerChoice();
                whoWon.calculateWinnerOfRoundvsComp(player1Choice, compChoice);
                Console.WriteLine("Round: "+goal);
                Console.WriteLine("My Score: "+ whoWon.win);
                Console.WriteLine("My Score: " + whoWon.lose);
                goal++;
            }
        }

        public void gameTime1vs1()
        {
            Console.WriteLine("Enter Player 1 name.");
            playerOneName = player1.playersname();
            Console.WriteLine("Enter Player 2 Name.");
            playerTwoName = player2.playersname();
            Console.WriteLine("Name of Player 1: {0}", playerOneName);
            Console.WriteLine("Name of Player 2: {0}", playerTwoName);

            int player1Choice = Convert.ToInt32(player1.getPlayerChoice());
            int player2Choice = Convert.ToInt32(player1.getPlayerChoice());
            whoWon.calculateWinnerOfRoundvsPlayer2(player1Choice, player2Choice);
        }
    }
}
