using System;
using tabuleiro;
using xadrez;

namespace ProjectXadrez {
    class Program {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 4));
                
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 2));
                
                // Testando PosiçãoXadres
                /*
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao()); // Resultando experado é 1, 2
                */
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
