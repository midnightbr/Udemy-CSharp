using System;
using System.Collections.Generic;
using System.Globalization;
using ExProp_30.Entities;

namespace ExProp_30 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char status = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (status == 'i') {
                    Console.Write("Customs fee: $");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (status == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list) {
                Console.WriteLine($"{product.Name} {product.PriceTag()}");
            }
        }
    }
}
