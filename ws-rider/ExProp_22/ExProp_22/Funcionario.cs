using System;
using System.Globalization;

namespace ExProp_22 {
    public class Funcionario {
        public string Nome;
        public double Salario, Imposto;

        public void SalarioLiquido() {
            Console.WriteLine();
            double Liquido = Salario - Imposto;
            Console.WriteLine("Funcionario: {0}, R${1}", Nome, Liquido.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }

        public void AumentoSalario() {
            Console.Write("Digite a porcetagem para aumentar o salario: ");
            double Aumento = double.Parse(Console.ReadLine());
            double Liquido = (Salario + (Salario * (Aumento / 100))) - Imposto;
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}, R${1}", Nome, Liquido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
