using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você ira digitar? ");
            int number = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
