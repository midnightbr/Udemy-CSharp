using System.Globalization;
using System.Text;

namespace ExProp_30.Entities {
    public class ImportedProduct : Product {
        public double CustomsFee { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price += CustomsFee;
        }

        public override string PriceTag() {
            TotalPrice();
            StringBuilder builder = new StringBuilder();
            builder.Append($"${Price.ToString("F2", CultureInfo.InvariantCulture)}");
            builder.Append($" (Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return builder.ToString();
        }
        
    }
}
