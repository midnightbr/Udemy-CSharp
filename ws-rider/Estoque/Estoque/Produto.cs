using System;
using System.Globalization;

namespace Estoque {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome + ", R$" 
                        + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                        + Quantidade + " unidades, Total: R$"
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
