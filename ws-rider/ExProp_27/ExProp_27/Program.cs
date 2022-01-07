using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExProp_27 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int employees = int.Parse(Console.ReadLine());
            
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < employees; i++) {
                Console.WriteLine("Employee #{0}:", (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: $");
                double salary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee idSearch = list.Find(x => x.Id == id);
                if (idSearch != null) {
                    Console.WriteLine("Id already exists!");
                    i--;
                }
                else {
                    list.Add(new Employee(id, name, salary));
                }
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else {
                Console.WriteLine("This is does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
