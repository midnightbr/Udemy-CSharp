using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: {0}", p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: {0}", p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a serem deletados: ");
            qte = int.Parse(Console.ReadLine());
            
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: {0}", p);
        }
    }
}
