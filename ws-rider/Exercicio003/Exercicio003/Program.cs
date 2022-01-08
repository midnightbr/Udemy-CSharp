using System;
using System.Numerics;

namespace Exercicio003 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores separados por espaço: ");
            // string[] vetor = Console.ReadLine().Split(' ');
            int[,] matriz = new int[tamanho, tamanho];
            for (int x = 0; x < tamanho; x++) {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int y = 0; y < tamanho; y++) {
                    matriz[x, y] = int.Parse(vetor[y]);
                }
            }

            Console.WriteLine("Main diagonal:");

            for (int x = 0; x < tamanho; x++) {
                for (int y = 0; y < tamanho; y++) {
                    if (x == y) {
                        Console.Write(matriz[x, y] + " ");
                    }
                }
            }

            Console.WriteLine();
            int negative = 0;
            foreach (int obj in matriz) {
                if (obj < 0) {
                    negative++;
                }
            }

            Console.WriteLine("Negative numbers = " + negative);
            
        }
    }
}
