namespace ClasseAbstrata.Entities {
    abstract class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Utilizando o protected, as subclasses podem alterar a variavel

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Para sobrescrever ou sobrepor uma função da superclasse na subclasse, basta adicionar o virtual
        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.0; // Adicionando a taxa de $5.0 para saque
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
