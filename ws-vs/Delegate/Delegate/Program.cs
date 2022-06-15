using Course.Services;
using Delegate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    internal class Program
    {
        //delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            //BinaryNumericOperation op = CalculationService.Sum;

            //double result = op.Invoke(a, b);
            //Console.WriteLine(result);

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a, b);

            // Separando os resultados
            Console.WriteLine("===========================");

            // Lista de produtos
            List<Product> list = new List<Product>();
            // Adicionando produtos na lista
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 35.00));
            list.Add(new Product("Monitor", 1300.00));
            list.Add(new Product("Memoria", 80.25));


            // Action -> Uma ação para ser executada na lista
            Console.WriteLine("Delegate - Action");
            // Nessa action, ela pegara o valor do produto e aumentara em 10%
            Action<Product> action = p => { p.Price += p.Price * 0.1; }; // Usando a expressão lambda

            // Comando para rodar toda a lista e aplicar a alteração
            list.ForEach(action);

            // Imprimindo a lista no console
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // Separando os resultados
            Console.WriteLine("===========================");

            // Predicate
            Console.WriteLine("Delegate - Predicate");
            // Removendo os produtos da lista que tenham um valor
            // maior que R$100.00
            list.RemoveAll(ProductTeste);

            // Imprimindo a lista no console
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            // Separando os resultados
            Console.WriteLine("===========================");

            // Func - A diferença entre o func e o action é que o action
            // é um tipo de operação void, ou seja, não retorna valor,
            // enquanto que a operação func retorna valor
            Console.WriteLine("Delegate - Func");

            // Func para colocar todos os nomes dos produtos em Maiusculas
            Func<Product, string> func = p => p.Name.ToUpper();

            // Obs.: No caso acima, na expressão lambda, não foi utilizado as chaves
            // pelo fato da expressão retorna um valor. Caso queira adicionar as
            // chaves, basta colocar a palavra return na expressão:
            // p => { return p.Name.ToUpper(); };

            // Criando uma nova lista com a alteração feita pelo func
            List<string> result = list.Select(func).ToList();

            // Imprimindo a lista no console
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        // Testando se o valor do produto é maior ou igual a R$100
        public static bool ProductTeste(Product product)
        {
            return product.Price >= 100.00;
        }
    }
}
