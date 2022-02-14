using System.Globalization;
using System.Text;

namespace ExProp_30.Entities {
    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
        
        public virtual string PriceTag() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"${Price.ToString("F2", CultureInfo.InvariantCulture)}");
            return builder.ToString();
        }
    }
}
