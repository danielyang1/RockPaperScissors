using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rock : Weapon
    {
        string item = "0";
        public void showWin()
        {
            Console.WriteLine("Rock Wins");
        }
        public void showLoss()
        {
            Console.WriteLine("Rock Loses");
        }
        public void showTie()
        {
            Console.WriteLine("Rock Ties");
        }

    }
}
