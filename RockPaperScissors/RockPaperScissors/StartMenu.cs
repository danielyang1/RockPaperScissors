using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StartMenu
    {
        Player player1= new Player();
        Player2 player2 = new Player2();
        Computer computerChoice = new Computer();
        Game playComputer = new Game();

        public void decidePlayer()
        {
            Console.WriteLine("Play Computer - 1  or  Play Person - 2");
            string playWho = Console.ReadLine();
            string playerOne;
            string playerTwo;

            switch (playWho)
            {
                case "1":
                    Console.WriteLine("You chose to play against Computer!");
                    playComputer.gameTime1vsComp();
                    break;
                case "2":
                    Console.WriteLine("You chose to play against another Player!");
                    playComputer.gameTime1vs1();
                    break;
                default:
                    decidePlayer();
                    break;
            }
        }
    }
}
