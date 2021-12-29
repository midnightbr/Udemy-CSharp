using System;
using System.Globalization;

namespace Estoque {
    public class Produto {
        
        /**
         * Por conversão da linguagem C#, quando se trabalha com atributos privativos,
         * deve-se nomea-los com _ seguinto por letras minusculas, como os
         * exemplos abaixo.
         */
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
        }
        
        /* Alterando o código para reaproveitar o construtor anterior, fazendo assim
         * com que não tenha tanta repetição no código, fazendo ele ficar mais limpo e eficaz.
         */
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }

        /**
         * Usando o método Properties para as funções Get e Set.
         */
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }
        
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", R$" 
                        + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                        + _quantidade + " unidades, Total: R$"
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
