using System;
using System.Globalization;

namespace Exercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            
            Console.Write("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o preço de um produto: ");
            double valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string nome2 = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = Double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome completo: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço: " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: " + nome2);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
