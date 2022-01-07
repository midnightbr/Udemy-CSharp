using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            // Criando uma matriz
            double[,] mat = new double[2, 3];

            // .lenght mostra o tamanho da matriz
            Console.WriteLine(mat.Length);
            
            // .Rank mostra a quantidade de linhas que a matriz tem
            Console.WriteLine(mat.Rank);
            
            // .GetLenght mostra o tamanho das dimensões
            // Dimensão 0 = tamanho em questão de linhas
            Console.WriteLine(mat.GetLength(0));
            // Dimensão 1 = tamanho em questão de colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
