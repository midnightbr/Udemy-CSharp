using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace ExProp_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, quant;
            double value, tot1, tot2, tot;

            Console.WriteLine("Digite o código, quantidade de peças e o valor unitario separados por espaço: ");
            string[] vetor = Console.ReadLine().Split(' ');

            cod = int.Parse(vetor[0]);
            quant = int.Parse(vetor[1]);
            value = Double.Parse(vetor[2], CultureInfo.InvariantCulture);
            tot1 = quant * value;
            
            Console.WriteLine("Digite o código, quantidade de peças e o valor unitario separados por espaço: ");
            string[] vetor2 = Console.ReadLine().Split(' ');

            cod = int.Parse(vetor2[0]);
            quant = int.Parse(vetor2[1]);
            value = Double.Parse(vetor2[2], CultureInfo.InvariantCulture);
            tot2 = quant * value;

            tot = tot1 + tot2;

            Console.WriteLine("Valor a pagar: R$" + tot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
