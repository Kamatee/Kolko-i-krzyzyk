using System;

namespace Plansza
{
    public class Board
    {
        private char[,] gameboard = new char[3, 3];

        public Board()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gameboard[row, col] = ' ';
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("   | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(" " + row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(gameboard[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        public int CzyWygrana(char player)
        {
            if (player == gameboard[0, 0] && player == gameboard[0, 1] && player == gameboard[0, 2])
            {
                return 1;
            }
            else if (player == gameboard[1, 0] && player == gameboard[1, 1] && player == gameboard[1, 2])
            {
                return 1;
            }
            else if (player == gameboard[2, 0] && player == gameboard[2, 1] && player == gameboard[2, 2])
            {
                return 1;
            }
            //kolumna wygrana
            else if (player == gameboard[0, 0] && player == gameboard[1, 0] && player == gameboard[2, 0])
            {
                return 1;
            }
            else if (player == gameboard[0, 1] && player == gameboard[1, 1] && player == gameboard[2, 1])
            {
                return 1;
            }
            else if (player == gameboard[0, 2] && player == gameboard[1, 2] && player == gameboard[2, 2])
            {
                return 1;
            }
            //ukosy wygrana
            else if (player == gameboard[0, 0] && player == gameboard[1, 1] && player == gameboard[2, 2])
            {
                return 1;
            }
            else if (player == gameboard[0, 2] && player == gameboard[1, 1] && player == gameboard[2, 1])
            {
                return 1;
            }
            //remis
            else
            {
                int licznik = 0;
                for (int row = 0; row < 3; row++)
                {
                    
                    for (int col = 0; col < 3; col++)
                    {
                        if(gameboard[row, col] == ' ')
                        {
                            licznik++;
                        }
                    }
                    
                }
                if(licznik == 0)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
                
        }
        public void ustawZnak(int row, int col, char player)
        {
            if(gameboard[row, col] == ' ')
            {
                gameboard[row, col] = player;
            }            
        }
        public bool czyPuste(int row, int col)
        {
            if (gameboard[row, col] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
