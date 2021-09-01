using System;
using System.Globalization; // Necessario para trocar a virgula pelo ponto como separador de casas decimais.

namespace EntradaDeDados_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Usando o ponto como separador no valor double

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = Double.Parse(vetor[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: " + nome + " Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade + " Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
