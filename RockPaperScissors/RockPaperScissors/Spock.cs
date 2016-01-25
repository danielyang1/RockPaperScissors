using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Spock : Weapon
    {
        string item = "3";
        public void showWin()
        {
            Console.WriteLine("Spock Wins");
        }
        public void showLoss()
        {
            Console.WriteLine("Spock Loses");
        }
        public void showTie()
        {
            Console.WriteLine("Tie");
        }
    }
}
