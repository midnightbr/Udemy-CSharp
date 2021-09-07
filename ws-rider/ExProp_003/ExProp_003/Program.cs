using System;

namespace ExProp_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dif;
            Console.WriteLine("Digite apenas números inteiros!");
            Console.Write("Número A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Número B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Número C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Número D: ");
            d = int.Parse(Console.ReadLine());

            dif = (a * b) - (c * d);
            
            Console.WriteLine("O total do produto entre A e B é " + (a * b));
            Console.WriteLine("O total do produto entre C e D é " + (c * d));
            Console.WriteLine("E a diferença entre A * B de C * D é " + dif);
        }
    }
}
