namespace Exercicio008.Entities.Services; 

public class BrazilTaxService : ITaxService {
    public double Tax(double amount) {
        if (amount <= 100.00) {
            return amount * 0.20;
        }
        else {
            return amount * 0.15;
        }
    }
}
