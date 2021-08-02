using System;

namespace Conversao_Implicita_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implícita
            /*
             * Como a diferença entre float e double é apenas a quantidade de bytes
             * que é possivel guardar, o tipo double pode receber sem nenhum problema o valor
             * do tipo float
             */
            float x = 4.5f;
            double y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            
            /*
             * Mais o mesmo não pode ser feito do double para o float,
             * já que o tipo double cabe 8 bytes e o float apenas 4 bytes.
             */
            double a = 5.1;
            float b;
            //b = a; <- Implicita
            /*
             * Nesse caso, o mais apropriado seria usar o Casting,
             * forçando assim a conversão mesmo se a conversão
             * causa perca de dados
             */
            b = (float)a; // Casting

            Console.WriteLine(a);
            Console.WriteLine(b);
            
            /*
             * Supondo que criaciamos duas variaveis inteiras e queremos dividir a mesma,
             * no entanto colocar o valor em uma variavel do tipo double para não peder informação,
             * se apenas eu coloca-se como no exemplo abaixo funcionaria?
             * Como mostrado abaixo, não.
             */
            int c = 35;
            int d = 4;
            double resultado = c / d;
            Console.WriteLine(resultado);
            // Para fazer essa operação sem perder dados, é necessario o uso do CASTING
            resultado = (double) c / d;
            Console.WriteLine(resultado);
        }
    }
}
