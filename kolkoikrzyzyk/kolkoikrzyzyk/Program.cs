using System;
using System.Data;
using Plansza;
    

namespace kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wersja dla dwóch graczy

            Board board = new Board();
            board.Print();
            char player = 'X';



            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Kolejka gracza {player}\n");
                board.Print();
                int row, col;
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
                if(board.CzyWygrana(player) == 1)
                {
                    Console.WriteLine($"Gracz {player} wygrał grę!");
                    board.Print();
                    break;
                }
                else if(board.CzyWygrana(player)== 2)
                {
                    Console.WriteLine("Remis!");
                    board.Print();
                    break;
                }
                player = ChangeTurn(player);
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
        //Sprawdź czy dane pole jest zajęte
        
            
    }
}
