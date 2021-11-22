using System;
using System.Globalization;

namespace AreadoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Metodo antigo
             * double xA, xB, xC, yA, yB, yC;
             */
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            Console.Write("A: ");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("B: ");
            //xB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("C: ");
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            Console.Write("A: ");
            // yA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("B: ");
            // yB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("C: ");
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double pX = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

            double pY = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

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
