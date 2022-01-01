using System;
using System.Globalization;

namespace CorrecaoEx_25 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;
            
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? [S/n] ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's') {
                Console.Write("Entre o valor de depósito inicial: R$");
                double depositoInicial = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: R$");
            double quantia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: R$");
            quantia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados:");
            Console.WriteLine(conta);
            
        }
    }
}
