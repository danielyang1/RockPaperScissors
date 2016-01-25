using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Paper : Weapon
    {
        string item = "1";
        public void showWin()
        {
            Console.WriteLine("Paper Wins");
        }
        public void showLoss()
        {
            Console.WriteLine("Paper Loses");
        }
        public void showTie()
        {
            Console.WriteLine("Tie");
        }
    }
}
