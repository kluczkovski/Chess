using System;
using tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(2, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(p);
        }
    }
}
