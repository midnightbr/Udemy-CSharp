using System;

namespace ExProp_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int quad = (int)Math.Pow(i, 2);
                int trip = (int)Math.Pow(i, 3);
                
                Console.Write(i + " ");
                Console.Write(quad + " ");
                Console.WriteLine(trip);
            }
        }
    }
}
