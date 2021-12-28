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

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            /**
             * Com o encapsulamento, pode-se adicionar as regras do negocio dentro
             * dos métodos, como no exemplo abaixo.
             * Na condicional abaixo, ele verficia se a variavel não está vazia e que tenha
             * mais que 1 caracter na frase, para depois poder ser alterado.
             */
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
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
