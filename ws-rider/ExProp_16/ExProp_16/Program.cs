using System;

namespace ExProp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do fatorial: ");
            int num = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 0; i < num; i++)
            {
                fat = (num - i) * fat;
            }

            Console.WriteLine("O fatorial de {0} é {1}", num, fat);
        }
    }
}
