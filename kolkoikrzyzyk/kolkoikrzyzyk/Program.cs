using System;

namespace kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            char[,] board = new char[3, 3];
            Initialize(board);

            

            Print(board);

            Console.Write("Wybierz rząd: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wybierz kolumnę: ");
            int col = Convert.ToInt32(Console.ReadLine());

            board[row, col] = 'X';

            Print(board);
   
        }


        
        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
