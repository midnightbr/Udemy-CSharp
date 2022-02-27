using System;
using tabuleiro;

namespace ProjectXadrez
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++) 
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        // Console.Write(tab.peca(i, j) + " ");
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else if (peca.Cor == Cor.Preto)
            {
                ConsoleColor orin = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(peca);
                Console.ForegroundColor = orin;

            }
        }
    }
}