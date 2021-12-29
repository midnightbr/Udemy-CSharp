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
        
        /**
         * O Auto propertie é uma forma mais simplificada de se declarar propriedades
         * que não precisa de lógica particulares para as operações Get e Set. A propertie nome
         * por exemplo, usa uma condição para validar o nome, o que não permite o uso de auto propertie.
         */
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }
        
        /* Alterando o código para reaproveitar o construtor anterior, fazendo assim
         * com que não tenha tanta repetição no código, fazendo ele ficar mais limpo e eficaz.
         */
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
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
            return _nome + ", R$" 
                        + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                        + Quantidade + " unidades, Total: R$"
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
