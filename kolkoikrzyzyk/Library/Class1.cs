using System;

namespace Library
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

    }
}
