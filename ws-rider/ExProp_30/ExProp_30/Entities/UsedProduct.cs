using System;
using System.Globalization;
using System.Text;

namespace ExProp_30.Entities {
    public class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            StringBuilder builder = new StringBuilder();
            builder.Append("(used) ");
            builder.Append($"${Price.ToString("F2", CultureInfo.InvariantCulture)}");
            builder.Append($"(Manufacture date: {ManufactureDate.ToShortDateString()})");
            return builder.ToString();
        }
    }
}
