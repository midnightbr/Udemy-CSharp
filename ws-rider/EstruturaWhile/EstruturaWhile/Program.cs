using System;
using System.Globalization;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number >= 0.0)
            {
                double raiz = Math.Sqrt(number);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                
                Console.Write("Digite um número: ");
                number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Console.WriteLine("Número negativo");
            
        }
    }
}
