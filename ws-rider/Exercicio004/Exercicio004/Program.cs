using System;
using System.Globalization;
using Exercicio004.Entities;
using Exercicio004.Entities.Enums;

namespace Exercicio004 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior | MidLevel | Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: $");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            
            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContracts; i++) {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double valuePerHour = Double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours); // Criando contrato
                worker.AddContract(contract); // Adicionando o contrato ao trabalhador

                Console.WriteLine();
                
            }
            
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2)); // Recortando o mês da string
            int year = int.Parse(monthYear.Substring(3)); // Reconrtando o ano da string

            Console.WriteLine();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthYear}: " +
                              $"R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
