using System;

namespace ExProp_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Até qual número deseja saber quais são os números impares? ");
            int num = int.Parse(Console.ReadLine());
            
            impar(num);
        }

        static void impar(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
