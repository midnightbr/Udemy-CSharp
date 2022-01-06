using System;

namespace Params {
    class Program {
        static void Main(string[] args) {
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);

            // Modificador de parâmetros REF
            int a = 10;
            Calculator.Triple(ref a); // Para passar o 'a' como referência.
            Console.WriteLine(a);

            // Modificador de parâmetros OUT
            int triple;
            Calculator.TripleSecond(a, out triple);
            Console.WriteLine(a);
            Console.WriteLine(triple);
            
            // Ambos (ref e out) são considerados "code smells" (design ruim) e devem ser evitados.
        }
    }
}
