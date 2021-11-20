using System;

namespace ExProp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de testes: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                double div = 0.0;
                string[] line = Console.ReadLine().Split(' ');
                double a = Double.Parse(line[0]);
                double b = Double.Parse(line[1]);

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    div = a / b;
                    Console.WriteLine(div);
                }

            }
        }
    }
}
