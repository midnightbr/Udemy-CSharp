using System;

namespace Operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ordem de precedência
            int n1 = 3 + 4 * 2; // Multiplicação primeiro, depois a soma.
            int n2 = (3 + 4) * 2;

            int n3 = 17 % 3;

            /*
             * Existe duas formas de mostrar a linguagem que queremos o resultado em double.
             * O primeiro seria usando o casting: (double) 10 / 8.
             * A segunda seria que, como estamos usando valores já declarados e não variaveis,
             * podemos adicionar um .0 para que a linguagem perceba que se trata de um resultado double.
             * EX:
             */
            double teste = 10 / 8;
            double n4 = 10.0 / 8.0;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(teste);
            Console.WriteLine(n4);
            
            // Usando agora os operadores para uma formula bhaskara de segundo grau.
            double a = 1.0, b = -3.0, c = -4.0;
            // Podemos usar duas opções para o delta de bhaskara (B² - 4AC)
            /*
             * A primeira seria usando o método tradicional:
             *  double delta = b * b - 4 * a * c;
             * No entanto, multiplicar o b por ele mesmo só nos daria o valor elevado ao quadrado,
             * e se precisasse elevar o valor por 5? Teria que escrever b * b * b * b * b? Faria o código
             * ficar grande demais. A outra formar seria usando a biblioteca Math, com a função Pow(potência).
             * Assim você colocar primeiro o valor e depois o expoente.
             */
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Para tirar a raiz quadrada, usar a função Math.Sqrt().
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
