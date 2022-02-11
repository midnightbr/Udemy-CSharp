using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio006.Entities;

namespace Exercicio006 {
    class Program {
        static void Main(string[] args) {
            
            List<Employee> list = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double valuePerHour = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y') {
                    Console.Write("Additional charge: $");
                    double additionalCharge = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();

            Console.WriteLine("Payments:");
            foreach (Employee emp in list) {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
