using System;

namespace ExProp_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos de testes? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = Double.Parse(line[0]);
                double b = Double.Parse(line[1]);
                double c = Double.Parse(line[2]);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
