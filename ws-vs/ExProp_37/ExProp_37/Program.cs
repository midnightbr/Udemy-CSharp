using Exercicio010.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
                
            }

            var avg = list.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = $" + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(x => x.Price < avg).OrderByDescending(x => x.Name).Select(x => x.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
