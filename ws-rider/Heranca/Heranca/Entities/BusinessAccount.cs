namespace Heranca.Entities {
    // Classe business herdando a classe account
    public class BusinessAccount : Account{
        public double LoanLimit { get; set; }

        public BusinessAccount() {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;   
            }
        }

        /*
         * A operação de saque com base.Withdraw(), puxa a operação da superclasse, ou seja, a operação de saque
         * com a taxa de $5.0 é executada também na subclasse BusinessAccount, no qual ainda aumentamos a taxa
         * de saque em mais $2.0 totalirazando $7.0
         */
        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
