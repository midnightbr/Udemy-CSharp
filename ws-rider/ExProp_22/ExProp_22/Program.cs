using System;
using System.Globalization;

namespace ExProp_22 {
    class Program {
        static void Main(string[] args) {
            Funcionario func = new Funcionario();
            
            Console.Write("Nome do funcionario: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario: R$");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$");
            func.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            func.SalarioLiquido();
            func.AumentoSalario();
        }
    }
}
