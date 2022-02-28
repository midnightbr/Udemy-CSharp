using System;
using tabuleiro;
using xadrez;

namespace ProjectXadrez {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada) {
                    Console.Clear();
                    Console.WriteLine();

                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    bool[,] possicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab, possicoesPossiveis);
                    
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
