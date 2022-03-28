using System.Globalization;
using System.Text;

namespace Exercicio008.Entities; 

public class Invoice {
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public Invoice(double basicPayment, double tax) {
        BasicPayment = basicPayment;
        Tax = tax;
    }

    // Propriedade Calculada
    public double TotalPayment {
        get { return BasicPayment + Tax; }
    }

    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Basic payment: ${BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}");
        builder.AppendLine($"Tax: ${Tax.ToString("F2", CultureInfo.InvariantCulture)}");
        builder.AppendLine($"Total payment: ${TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");
        return builder.ToString();
    }
}
