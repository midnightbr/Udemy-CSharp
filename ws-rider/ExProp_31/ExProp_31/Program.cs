using System;
using System.Collections.Generic;
using System.Globalization;
using ExProp_31.Entities;

namespace ExProp_31 {
    class Program {
        static void Main(string[] args) {
            List<Contributor> list = new List<Contributor>();
            
            Console.Write("Enter the number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: $");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') {
                    Console.Write("Health expenditures: $");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PrivatePerson(name, income, health));
                }
                else {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double total = 0.0;
            foreach (Contributor contributor in list) {
                Console.WriteLine($"{contributor.Name}: " +
                                  $"${contributor.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                total += contributor.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${total.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
