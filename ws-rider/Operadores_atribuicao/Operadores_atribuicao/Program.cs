using System;

namespace Operadores_atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando uma variavel com um valor do tipo inteiro
            int a = 10;
            Console.WriteLine(a);
            
            // A variavel 'a' recebe o valor dela com uma adição do valor 2
            a += 2;
            Console.WriteLine(a);
            
            // A variavel 'a' recebe o valor dela com uma subtração do valor 2
            a -= 2;
            Console.WriteLine(a);
            
            // A variavel 'a' recebe o valor dela com uma multiplicação por 2
            a *= 2;
            Console.WriteLine(a);
            
            // A variavel 'a' recebe o valor dela com uma divisão por 2
            a /= 2;
            Console.WriteLine(a);
            
            // A variavel 'a' recebe o valor do resto da divisão do valor dela por 3
            a %= 3;
            Console.WriteLine(a);
        }
    }
}
