using System;

namespace ExProp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a coordenada X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(quadrante(x, y));

        }

        static string quadrante(double a, double b)
        {
            string res = "";
            
            if (a > 0 && b > 0)
            {
                res = "Primeiro";
            }
            else if (a > 0 && b < 0)
            {
                res = "Quarto";
            }
            else if (a < 0 && b < 0)
            {
                res = "Terceiro";
            }
            else if (a < 0 && b > 0)
            {
                res = "Segundo";
            }

            return res;
        }
    }
}
