using System;
using System.Globalization;
using ExProp_32.Entities;
using ExProp_32.Entities.Exception;

namespace ExProp_32 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: $");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: $");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();
                
                Console.Write("Enter amount for withdraw: $");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);

                Console.WriteLine("New balance: " + account);
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Error unexpected: " + e.Message);
            }
        }
    }
}
