using System;
using System.Numerics;

namespace ExProp_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois valores inteiros separados por espaço: ");
            string[] vetor = Console.ReadLine().Split(' ');
            int number01 = int.Parse(vetor[0]);
            int number02 = int.Parse(vetor[1]);

            /* Metodo mais longo
            if (number01 > number02)
            {
                int m = number01 % number02;
                if (m == 0)
                {
                    Console.WriteLine(m);
                    Console.WriteLine("Os numeros " + number01 + " e " + number02 + " são multpilos");
                }
                else
                {
                    Console.WriteLine(m);
                    Console.WriteLine("Os numeros " + number01 + " e " + number02 + " não são multiplos");
                }
            }
            else
            {
                int m = number02 % number01;
                if (m == 0)
                {
                    Console.WriteLine(m);
                    Console.WriteLine("Os numeros " + number01 + " e " + number02 + " são multpilos");
                }
                else
                {
                    Console.WriteLine(m);
                    Console.WriteLine("Os numeros " + number01 + " e " + number02 + " não são multiplos");
                }
            }
            */
            if (number01 % number02 == 0 || number02 % number01 == 0)
            {
                Console.WriteLine("Os numeros " + number01 + " e " + number02 + " são multpilos");
            }
            else
            {
                Console.WriteLine("Os numeros " + number01 + " e " + number02 + " não são multiplos");
            }
        }
    }
}
