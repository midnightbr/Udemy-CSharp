using System;

namespace ExProp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                int div = num % i;

                if (div == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
