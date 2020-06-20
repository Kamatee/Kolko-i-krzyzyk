using System;

namespace kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wersja dla dwóch graczy

            char player = 'X';
            char[,] board = new char[3, 3];
            Initialize(board);


            while (true)
            {
                Console.Clear();
                Print(board);


                Console.Write("Wybierz rząd: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wybierz kolumnę: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;

                //warunek wygranej (8 możliwości) i remisu

                //rząd wygrana
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                //kolumna wygrana
                else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                //ukosy wygrana
                else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine(player + " wygrał/a grę!");
                    Console.ReadKey();
                }
                //remis
                else
                    Console.WriteLine("Remis!");

                player = ChangeTurn(player);

                

            }
   
        }


        //Plansza do gry
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
            Console.WriteLine("   | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(" " + row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        //Zmiana tury
        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
    }
}
