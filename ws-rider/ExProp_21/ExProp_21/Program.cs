using System;
using System.Globalization;

namespace ExProp_21 {
    class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();
            
            Console.WriteLine("Entre com os dados do retângulo:");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            ret.Area();

            Console.WriteLine("Area: {0}", ret.Are.ToString("F2", CultureInfo.InvariantCulture));
            
            ret.Perimetro();

            Console.WriteLine("Perímetro: {0}", ret.Per.ToString("F2", CultureInfo.InvariantCulture));
            
            ret.Diagonal();

            Console.WriteLine("Diagonal: {0}", ret.Diag.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
