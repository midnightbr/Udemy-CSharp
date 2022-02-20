using System.Globalization;
using System.Text;
using ExProp_32.Entities.Exception;

namespace ExProp_32.Entities {
    public class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() {
        }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (WithdrawLimit < amount) {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            else if (Balance <= 0.0 || Balance < amount) {
                throw new DomainException("Not enough balance!");
            }

            Balance -= amount;
        }

        public override string ToString() {
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
