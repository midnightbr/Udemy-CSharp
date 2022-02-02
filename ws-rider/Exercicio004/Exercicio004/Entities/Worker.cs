using System.Collections.Generic;
using Exercicio004.Entities.Enums;

namespace Exercicio004.Entities {
    public class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação de duas classes diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Instanciando para não ser nula

        public Worker() {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }
        
        // Somando os valores dos contratos
        public double Income(int year, int month) {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}
