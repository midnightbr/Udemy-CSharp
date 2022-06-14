using Course.Services;
using Delegate.Entities;
using System;
using System.Collections.Generic;

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

            // Predicate
            List<Product> list = new List<Product>();
            // Adicionando produtos na lista
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 35.00));
            list.Add(new Product("Monitor", 1300.00));
            list.Add(new Product("Memoria", 80.25));

            // Removendo os produtos da lista que tenham um valor
            // maior que R$100.00
            list.RemoveAll(ProductTeste);

            // Imprimindo a lista no console
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        // Testando se o valor do produto é maior ou igual a R$100
        public static bool ProductTeste(Product product)
        {
            return product.Price >= 100.00;
        }
    }
}
