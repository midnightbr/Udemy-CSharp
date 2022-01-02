using System;
using System.Threading.Channels;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            // Declarando uma variavel nullable, fazendo com que receba o valor nulo
            double? x = null;
            double? y = 10.0;

            // Função GetValueOrDefault que mostra o valor da variavel ou o valor default (padrão)
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            
            // Função para testar se a variavel tem valor ou não. Esse teste retorna true ou false
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            
            // A função value, nada mais do que mostra o valor da variavel
            if (x.HasValue) {
                // Como o valor de x é nulo, isso quebrada a aplicação causando um erro
                Console.WriteLine(x.Value);
            }
            else {
                /**
                 * Para que a aplicação não quebre, tem este teste de condição, para caso haja algum valor
                 * na variavel, que ela possa ser mostrada, caso não haja, vai aparacer uma mensagem de
                 * que a variavel é nulla.
                 */ 
                Console.WriteLine("X is null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }
            
            
            /**
             * Operador de coalescência nula:
             * Supondo que tenhamos uma variavel do tipo nullable, mais temos outra variavel que não seja
             * e queremos atribuir a variavel nullable a essa outra variavel, no entanto, queremos que
             * caso a variavel nullable tenha algum valor, seja passado para essa
             * outra variavel,
             * caso não haja e a variavel seja nulo, que passe outro valor. É isso que o exemplo abaixo demonstra.
             */

            double a = x ?? 5.0;
            double b = y ?? 0.0;
            
            
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
