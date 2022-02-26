﻿using System;
using tabuleiro;
using xadrez;

namespace ProjectXadrez {
    class Program {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));
            
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}