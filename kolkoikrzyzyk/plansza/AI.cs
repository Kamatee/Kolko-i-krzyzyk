using System;
using System.Collections.Generic;
using System.Text;

namespace Plansza
{
    public class AI
    {
        public AI()
        {
            
        }
        public int[] wykonajRuch()
        {
            int[] koordynaty = new int[2];
            Random liczbaLosowa = new Random();
            for(int i=0; i<2; i++)
            {
                koordynaty[i] = liczbaLosowa.Next(0,3);
            }
            return koordynaty;
        }

    }
}
