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
                PartidaDeXadrez partida = new PartidaDeXadrez();
               
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine("");
                    Console.Write("Digite posição de Origem");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    Console.Write("Digite posição de Destino");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }

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
