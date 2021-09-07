using System;
using System.Globalization;

namespace ExProp_002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, pi, raio;

            pi = 3.14159;

            Console.WriteLine("Calculando a área do circulo!");
            Console.Write("Digite o valor do raio do circulo: ");
            raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Calculando área do circulo
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Area do circulo com um raio de " + raio.ToString(CultureInfo.InvariantCulture) +
                              " é de " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
