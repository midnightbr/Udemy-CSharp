using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista de dados para demonstrar a utilização de Linq
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Definindo expressão query (Linq)
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            // No caso acima, utilizamos a função 'where' do linq, no qual
            // ele vai testar se o numero é par ou impar.
            // Após esse teste, ele seleciona o objeto com a função 'select'
            // no qual aplica uma alteração no objeto, multiplicando ele por 10

            // Executando a query
            // Imprimindo a lista modificado somente com valores pares
            // multiplicados por 10
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
            
            // Separando as listas
            Console.WriteLine("=============");
            
            // Imprimindo a lista original
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}
