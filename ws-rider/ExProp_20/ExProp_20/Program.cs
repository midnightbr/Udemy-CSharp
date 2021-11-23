using System;
using System.Globalization;

namespace ExProp_20 {
    class Program {
        static void Main(string[] args) {
            Funcionarios func1 = new Funcionarios();
            Funcionarios func2 = new Funcionarios();
            
            // Coletando dados do primeiro funcionario
            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();
            Console.Write("Salário: R$");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Coletando dados do segundo funcionario
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salário: R$");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.salario + func2.salario) / 2;

            Console.WriteLine("Salário médio: R${0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
