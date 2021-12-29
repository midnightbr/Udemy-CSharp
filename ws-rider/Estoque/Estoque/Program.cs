using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900.00, 15);

            p.Nome = "TV 4K";
            
            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Preço: R$" + p.Preco);
            Console.WriteLine("Quantidade: " + p.Quantidade);
        }
    }
}
