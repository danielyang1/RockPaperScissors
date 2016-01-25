using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Compare
    {
        Player player1 = new Player();
        Player2 player2 = new Player2();
        Computer computer = new Computer();
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Spock spock = new Spock();
        Lizard lizard = new Lizard();
        public int win = 0;
        public int lose = 0;
        

        public int calculateWinnerOfRoundvsComp(int player1, int comp)
        {
            Console.WriteLine("Choice of Player 1: "+player1);
            Console.WriteLine("Choice of Computer: "+comp);
            if (player1 == 0)//rock chosen
            {
                switch ((5 + player1 - comp) % 5)
                {
                    case 0:
                        rock.showTie();
                        return win;
                        break;
                    case 1:
                        rock.showWin();
                        win++;
                        Console.WriteLine("Case 1 of Rock: "+win);
                        return win;
                        break;
                    case 2:
                        rock.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        rock.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        rock.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 1)
            {
                switch ((5 + player1 - comp) % 5)
                {
                    case 0:
                        paper.showTie();
                        return win;
                        break;
                    case 1:
                        paper.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        paper.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        paper.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        paper.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 2)
            {
                switch ((5 + player1 - comp) % 5)
                {
                    case 0:
                        scissors.showTie();
                        return win;
                        break;
                    case 1:
                        scissors.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        scissors.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        scissors.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        scissors.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 3)
            {
                switch ((5 + player1 - comp) % 5)
                {
                    case 0:
                        spock.showTie();
                        return win;
                        break;
                    case 1:
                        spock.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        spock.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        spock.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        spock.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 4)
            {
                switch ((5 + player1 - comp) % 5)
                {
                    case 0:
                        lizard.showTie();
                        return win;
                        break;
                    case 1:
                        lizard.showWin();
                        return win;
                        win++;
                        break;
                    case 2:
                        lizard.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        lizard.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        lizard.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
        return 0;

        }
            public int calculateWinnerOfRoundvsPlayer2(int player1, int player2)
        {
            //return win;
            Console.WriteLine(player2);
            Console.WriteLine("Choice of Player 1: " + player1);
            Console.WriteLine("Choice of Player 2: " + player2);
            if (player1 == 0)//rock chosen
            {
                switch ((5 + player1 - player2) % 5)
                {
                    case 0:
                        rock.showTie();
                        return win;
                        break;
                    case 1:
                        rock.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        rock.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        rock.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        rock.showLoss();
                        lose++;
                        return lose;
                        break;
                }

            }

            else if (player1 == 1)
            {
                switch ((5 + player1 - player2) % 5)
                {
                    case 0:
                        paper.showTie();
                        return win;
                        break;
                    case 1:
                        paper.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        paper.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        paper.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        paper.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 2)
            {
                switch ((5 + player1 - player2) % 5)
                {
                    case 0:
                        scissors.showTie();
                        return win;
                        break;
                    case 1:
                        scissors.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        scissors.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        scissors.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        scissors.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 3)
            {
                switch ((5 + player1 - player2) % 5)
                {
                    case 0:
                        spock.showTie();
                        return win;
                        break;
                    case 1:
                        spock.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        spock.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        spock.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        spock.showLoss();
                        lose++;
                        return lose;
                        break;
                }
            }
            else if (player1 == 4)
            {
                switch ((5 + player1 - player2) % 5)
                {
                    case 0:
                        lizard.showTie();
                        return win;
                        break;
                    case 1:
                        lizard.showWin();
                        win++;
                        return win;
                        break;
                    case 2:
                        lizard.showLoss();
                        lose++;
                        return lose;
                        break;
                    case 3:
                        lizard.showWin();
                        win++;
                        return win;
                        break;
                    case 4:
                        lizard.showLoss();
                        lose++;
                        return lose;
                        break;
                }
        }return 0;
            }
    }
}
    