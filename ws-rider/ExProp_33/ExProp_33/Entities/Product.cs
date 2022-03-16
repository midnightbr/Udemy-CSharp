namespace ExProp_33.Entities; 

public class Product {
    public string Name { get; set; }
    public double Value { get; set; }
    public int Qtd { get; set; }
    
    public Product(){}

    public Product(string name, double value, int qtd) {
        Name = name;
        Value = value;
        Qtd = qtd;
    }

    public double Total() {
        return Value * Qtd;
    }

    public override string ToString() {
        return $"{Name} - ${Value} - {Qtd}";
    }
}
