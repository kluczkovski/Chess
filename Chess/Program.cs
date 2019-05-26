using System;
using tabuleiro;
using Xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 1));


                tab.ColocarPecas(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro:" + e.Message);

            }

            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());


        }
    }
}
