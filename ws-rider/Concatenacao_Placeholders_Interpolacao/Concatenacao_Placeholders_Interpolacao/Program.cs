using System;

namespace Concatenacao_Placeholders_Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Clayton";
            int years = 34;
            double balance = 556.67548;
            
            // Método Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais", name, years, balance);
            
            // Interpolação
            Console.WriteLine($"{name} tem {years} anos e tem saldo igual a R${balance:F2} reais.");
            
            // Concatenação
            Console.WriteLine(name + " tem " + years + " anos e tem saldo igual a R$" + balance.ToString("F2") + " reais");
        }
    }
}
