using System;
using System.Globalization;

namespace AreadoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            Console.Write("A: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("B: ");
            xB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("C: ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            Console.Write("A: ");
            yA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("B: ");
            yB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("C: ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine("Área de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
