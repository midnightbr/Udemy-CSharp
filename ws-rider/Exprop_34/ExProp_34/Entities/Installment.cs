using System.Globalization;
using System.Text;

namespace ExProp_34.Entities; 

public class Installment {
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateTime dueDate, double amount) {
        DueDate = dueDate;
        Amount = amount;
    }

    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        builder.Append(DueDate.ToString("dd/MM/yyyy"));
        builder.Append(" ");
        builder.Append($"R${Amount.ToString("F2", CultureInfo.InvariantCulture)}");

        return builder.ToString();
    }
}
