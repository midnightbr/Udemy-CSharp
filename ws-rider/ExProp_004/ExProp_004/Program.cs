using System;
using System.Globalization;

namespace ExProp_004
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour, number, value, salary;

            Console.Write("Digite o número do funcionario: ");
            number = double.Parse(Console.ReadLine());
            Console.Write("Digite as horas trabalhadas: ");
            hour = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor por hora trabalhada: ");
            value = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = value * hour;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Salary: U$" + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
