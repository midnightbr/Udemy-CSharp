using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900.00, 15);

            Console.WriteLine("Nome: " + p.GetNome());
            Console.WriteLine("Preço: R$" + p.GetPreco());
            Console.WriteLine("Quantidade: " + p.GetQuantidade());
        }
    }
}
