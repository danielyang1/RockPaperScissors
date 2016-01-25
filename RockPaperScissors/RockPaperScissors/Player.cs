using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string playersname()
        {
            return Console.ReadLine();
        }

        public string getPlayerChoice()
        {
            Console.WriteLine("Choose  Rock-0 , Paper-1 , Scissors-2 , Spock-3 or Lizard-4 ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    Console.WriteLine("You chose Rock");
                    break;
                case "1":
                    Console.WriteLine("You chose Paper");
                    break;
                case "2":
                    Console.WriteLine("You chose Scissors");
                    break;
                case "3":
                    Console.WriteLine("You chose Spock");
                    break;
                case "4":
                    Console.WriteLine("You chose Lizard");
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
            return choice;
        }
    }
}
