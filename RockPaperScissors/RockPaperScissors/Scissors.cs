using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Scissors : Weapon
    {
        string item = "2";
        public void showWin()
        {
            Console.WriteLine("Scissors Wins");
        }
        public void showLoss()
        {
            Console.WriteLine("Scissors Loses");
        }
        public void showTie()
        {
            Console.WriteLine("Tie");
        }
    }
}
