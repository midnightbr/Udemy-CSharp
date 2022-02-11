namespace Heranca.Entities {
    public class SavingsAccount : Account{
        public double InterestRate { get; set; }

        public SavingsAccount() {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        /*
         * Selando um method para que ele não possa ser utilizado em uma subclasse novamente, ou seja
         * não pode ser sobreposto para uma nova subclasse. O mesmo pode ser feito com as classes, no qual
         * basta adicionar a palavra sealed no começo da classe
         * para que a mesma não seja herdada. Exemplo: sealed class SavingsAccount.
         */
        public sealed override void Withdraw(double amount) {
            Balance -= amount;
        }
    }
}
