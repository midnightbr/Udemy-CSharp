using System.Globalization;
using ExProp_33.Entities;

string sourcePath = @"C:\Users\marco\Documents\CSharp\ws-rider\ExProp_33\ExProp_33\itens.csv";
string targetPath = @"C:\Users\marco\Documents\CSharp\ws-rider\ExProp_33\ExProp_33\Out\summary.csv";

try {
    string[] lines = File.ReadAllLines(sourcePath);
    for (int i = 0; i < lines.Length - 1; i++) {
        string[] itens = lines[i].Split(";");
        string name = itens[0];
        double value = double.Parse(itens[1], CultureInfo.InvariantCulture);
        int quantity = int.Parse(itens[2]);

        Product product = new Product(name, value, quantity);

        using (StreamWriter sw = File.AppendText(targetPath)) {
            sw.WriteLine(name + ", $" + product.Total());
        }
    }

    using (StreamReader sr = File.OpenText(targetPath)) {
        while (!sr.EndOfStream) {
            Console.WriteLine(sr.ReadLine());
        }
    }
    
}
catch (IOException e) {
    Console.WriteLine("Error: " + e.Message);
}