using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args) {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1003, "Maria", 0.0, 100.00);
            
            // Upcasting - SubClasse -> SuperClasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1002, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            
            // Downcasting - SuperClasse -> SubClasse - Operação Insegura
            // BusinessAccount bacc2 = acc2; // Vai gerar um erro pelo simples fato do tipo acc2 ser Account(SuperClasse)
            BusinessAccount bacc2 = (BusinessAccount)acc2; // Agora com um casting, o compilador aceita
            bacc2.Loan(100.00);
            /*
             * Forçando um erro de converesão, já que o objeto acc3 é do tipo SavingsAccount e não do
             * tipo BusinessAccount, no qual o erro só ira aparecer na execusão do programa.
             */
            //BusinessAccount bacc3 = (BusinessAccount)acc3;
            // Fazendo o programa testar qual a instancia do objeto antes de converter
            if (acc3 is BusinessAccount) {
                BusinessAccount bacc3 = (BusinessAccount)acc3;
                bacc3.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) {
                SavingsAccount sacc = (SavingsAccount)acc3;
                sacc.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
