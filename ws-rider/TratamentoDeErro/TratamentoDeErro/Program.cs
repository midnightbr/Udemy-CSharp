using System;

namespace TratamentoDeErro {
    class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            // Tratando o erro especifico quando a divisão é por zero
            catch (DivideByZeroException) {
                Console.WriteLine("Division by zero is not allowed");
            }
            // Tratando o erro especifico quando o tipo do valor não é do tipo int
            catch (FormatException e) {
                Console.WriteLine("Format error! " + e.Message);
            }
            // Tratamento de erros de forma geral (generica)
            catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}