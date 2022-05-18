using System;

namespace TiposBasicos {
    class Program {
        static void Main(string[] args) {
            // sbyte recebe valores entre -128 até 127
            sbyte x = 100;
            // Diferença entre o sbyte e o SByte?
            // O sbyte é tipo do C# enquanto o SByte é um tipo do dotnet framework.
            // Os tipos do dotenet framework só podem ser usados quando o 'using System' obrigatoriamente seja declarado.
            SByte y = 100;

            Console.WriteLine(x);
            Console.WriteLine(y);


            // byte recebe valores de 0 até 255 apenas
            byte n1 = 255;

            Console.WriteLine(n1);

            // Int recebe valores de -2147483647 até 2147483647 e é o comumente uns dos mais utilizados;
            int n2 = 2147483647;

            Console.WriteLine(n2);

            // Long para poder trabalhar com número muito grandes com maior precisão (ainda do tipo inteiro)
            long n4 = 2147483648L; // É recomendado usar a letra L no final do número para demonstrar que está trabalhando com números longos.

            Console.WriteLine(n4);
        }
    }
}
