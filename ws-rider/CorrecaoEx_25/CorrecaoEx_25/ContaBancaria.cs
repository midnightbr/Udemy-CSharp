using System.Globalization;

namespace CorrecaoEx_25 {
    public class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            /**
             * Para ser condizente com a regra de negecoio, é de grande importancia que se use o método responsavel para
             * efetuar o deposito. Assim, caso haja alguma alteração e seja acrescida qualquer outra informação ou método,
             * sera atualizado também o deposito inicial. Simplificando a atualização e a manutenção.
             */
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            // Valor de deposito
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            // Valor do saque
            Saldo -= quantia;
            // Taxa de saque
            Saldo -= 5;
        }

        public override string ToString() {
            return "Conta: " 
                + Numero
                + ", Titular: " 
                + Titular
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
