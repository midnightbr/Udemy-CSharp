using System;
using System.Globalization;

namespace ExProp_25 {
    class Program {
        static void Main(string[] args) {
            // double deposito;
            
            Console.Write("Digite o número da conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o nome do titular: ");
            string nome = Console.ReadLine();
            
            ContaBancaria banco = new ContaBancaria(nome, conta);
            
            Console.Write("Haverá déposito inicial? [S/n] ");
            string inicial = Console.ReadLine();
            if (inicial == "s" || inicial == "S") {
                Console.Write("Entre com o valor de depósito inicial: R$");
                // deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                banco.SaldoInicial(saldoInicial);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: R${2}", banco.Conta, banco.Nome, 
                banco.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: R$");
            // deposito = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Deposito(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: R${2}", banco.Conta, banco.Nome, 
                banco.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            
            Console.Write("Entre com o valor para saque: R$");
            // double saque = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Saque(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: R${2}", banco.Conta, banco.Nome, 
                banco.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
