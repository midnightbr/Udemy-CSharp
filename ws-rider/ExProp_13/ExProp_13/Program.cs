using System;

namespace ExProp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros ira digitar? ");
            int num = int.Parse(Console.ReadLine());
            
            faixa(num);
            
        }

        static void faixa(int num)
        {
            int IN = 0;
            int OUT = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Digite um número: ");
                int number = int.Parse(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    IN += 1;
                }
                else if (number <= 10 || number >= 20)
                {
                    OUT += 1;
                }
            }

            Console.WriteLine("IN: {0}", IN);
            Console.WriteLine("OUT: {0}", OUT);
        }
    }
}
