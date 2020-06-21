using System;
using System.Data;
using Plansza;
    

namespace kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {            
            

            Board board = new Board();

            Console.WriteLine("Wybierz tryb gry:");
            Console.WriteLine("1. Tryb dla jednego gracza");
            Console.WriteLine("2. Tryb dla dwóch graczy");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    AI bot = new AI();
                    SinglePlayer(board, bot);
                    break;
                case 2:
                    MultiPlayer(board);
                    break;
                default:
                    break;
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
        static void MultiPlayer(Board board)
        {
            //Wersja dla dwóch graczy
            char player = 'X';
            int row, col;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Kolejka gracza {player}\n");
                board.Print();                
                Console.Write("\nWybierz rząd: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wybierz kolumnę: ");
                col = Convert.ToInt32(Console.ReadLine());

                while (board.czyPuste(row, col) == false)
                {
                    Console.WriteLine("Błąd! Wybrana komórka jest już zajęta!");
                    Console.Write("Wybierz rząd: ");
                    row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Wybierz kolumnę: ");
                    col = Convert.ToInt32(Console.ReadLine());
                }
                board.ustawZnak(row, col, player);
                if (board.CzyWygrana(player) == 1)
                {
                    Console.WriteLine($"Gracz {player} wygrał grę!");
                    board.Print();
                    break;
                }
                else if (board.CzyWygrana(player) == 2)
                {
                    Console.WriteLine("Remis!");
                    board.Print();
                    break;
                }
                player = ChangeTurn(player);
            }

        }
        //dla jednego gracza
        static void SinglePlayer(Board board, AI bot)
        {
            char player = 'X';
            int row = 0, col = 0;
            int[] koordynaty = new int[2];
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Kolejka gracza {player}\n");
                board.Print();
                
                
                if (player == 'X')
                {
                    Console.Write("\nWybierz rząd: ");
                    row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Wybierz kolumnę: ");
                    col = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    koordynaty = bot.wykonajRuch();
                    row = koordynaty[0];
                    col = koordynaty[1];

                }
                while (board.czyPuste(row, col) == false)
                {
                    if (player == 'X')
                    {
                        Console.Write("\nWybierz rząd: ");
                        row = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Wybierz kolumnę: ");
                        col = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        koordynaty = bot.wykonajRuch();
                        row = koordynaty[0];
                        col = koordynaty[1];

                    }
                }
                board.ustawZnak(row, col, player);
                if (board.CzyWygrana(player) == 1)
                {
                    Console.WriteLine($"Gracz {player} wygrał grę!");
                    board.Print();
                    break;
                }
                else if (board.CzyWygrana(player) == 2)
                {
                    Console.WriteLine("Remis!");
                    board.Print();
                    break;
                }
                player = ChangeTurn(player);
            }
            }
            
            
        
            
    }
}
