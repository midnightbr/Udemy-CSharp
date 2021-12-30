using System;

namespace ExProp_25 {
    public class ContaBancaria {
        private int _conta;
        private string _nome;
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int conta) {
            _conta = conta;
            _nome = nome;
        }

        public ContaBancaria(string nome, int conta, double saldo) : this(nome, conta){
            Saldo = saldo;
        }
        
        public int Conta {
            get { return _conta; }
            set {
                if (value != null && value.ToString().Length > 3 && _conta == 0) {
                    _conta = value;
                }
            }
        }
        
        public string Nome {
            get { return _nome; }
            set {
                if (value != null) {
                    _nome = value;
                }
            }
        }

        public void SaldoInicial(double saldo) {
            Saldo = saldo;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque;
            Saldo -= 5;
        }
    }
}
