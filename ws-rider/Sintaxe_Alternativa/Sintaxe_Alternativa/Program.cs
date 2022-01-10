using System;
using System.Globalization;

namespace Sintaxe_Alternativa {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite um valor: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            /**
             * Esse argumento utilizado abaixo, é um teste no qual dependendo do resultado, a variavel vai receber
             * um valor diferente, substituindo assim a utilização de if e else em cenarios simples como esse,
             * deixando o código mais limpo e organizado.
             */
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
