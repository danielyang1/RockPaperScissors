using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer
    {
        int computerChoice;
        string name = "Computer";
        Random randNum = new Random();
        public int getComputerChoice()
        {
            computerChoice = randNum.Next(0,5);
            //Console.WriteLine("Random Number: {0}", computerChoice);
            switch (computerChoice)
            {
                case 0:
                    Console.WriteLine("{0} chose Rock" ,name);
                    return computerChoice;
                case 1:
                    Console.WriteLine("{0} chose Paper", name);
                    return computerChoice;
                case 2:
                    Console.WriteLine("{0} chose Scissors", name);
                    return computerChoice;
                case 3:
                    Console.WriteLine("{0} chose Spock", name);
                    return computerChoice;
                case 4:
                    Console.WriteLine("{0} chose Lizard", name);
                    return computerChoice;
            }
            return 5;
        }
    }
}
