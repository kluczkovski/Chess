﻿using System;
using tabuleiro;
using Xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPecas(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
             
        }
    }
}
