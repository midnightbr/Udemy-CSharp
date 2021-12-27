using System;
using System.Globalization;

namespace ExProp_23 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            
            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("N1: ");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("N2: ");
            aluno.nota2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("N3: ");
            aluno.nota3 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //aluno.Nota(aluno.nota1, aluno.nota2, aluno.nota3);
            aluno.Final();
        }
    }
}
