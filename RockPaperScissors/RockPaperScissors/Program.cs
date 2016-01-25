using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu letsPlay = new StartMenu();
            letsPlay.decidePlayer();
            Console.ReadKey();
        }
    }
}
