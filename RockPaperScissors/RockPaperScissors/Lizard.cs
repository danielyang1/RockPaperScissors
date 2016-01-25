using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Lizard : Weapon
    {
        string item = "4";
        public void showWin()
        {
            Console.WriteLine("Lizard Wins");
        }
        public void showLoss()
        {
            Console.WriteLine("Lizard Loses");
        }
        public void showTie()
        {
            Console.WriteLine("Tie");
        }
    }
}
