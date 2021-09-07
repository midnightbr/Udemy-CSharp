using System;
using System.Globalization;

namespace ExProp_006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Digite 3 valores separados por espaço:");
            string[] vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double tria, cir, trap, quad, reta, pi;
            pi = 3.14159;
            tria = (a * c) / 2;
            cir = pi * Math.Pow(c, 2);
            trap = (a + b) * c / 2;
            quad = Math.Pow(b, 2);
            reta = a * b;
            Console.WriteLine("Triangulo: " + tria.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + reta.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
