using System;
using System.Globalization;

namespace ExProp_24 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dolar: $");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? $");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double conversao = ConversorDeMoeda.Conversao(cotacao, quantidade);
            Console.WriteLine("Valor a ser pago em reais: R${0}", conversao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
