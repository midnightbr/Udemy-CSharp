using System;
using System.Globalization;

namespace Vetores {
    public class Exemplo02 {
        public void MediaPreco() {
            Console.Write("Entre com a quantidade de produtos: ");
            int quant = int.Parse(Console.ReadLine());

            Product[] vect = new Product[quant];

            for (int i = 0; i < quant; i++) {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o valor do produto: R$");
                double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                /**
                 * Instanciando um novo produto sem construtor, de forma direta,
                 * mais pode caso queira criar um constructor
                 */
                vect[i] = new Product { Name = name, Price = price };
            }

            // Somando os preços dos produtos
            double sum = 0;
            for (int i = 0; i < quant; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / quant;

            Console.WriteLine("AVERAGE PRICE = {0}", avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
