using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio007.Entities;
using Exercicio007.Entities.Enums;

namespace Exercicio007 {
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();
            
            Console.Write("Enter the number of shapes: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Colo (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r') {
                    Console.Write("Width: ");
                    double width = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else {
                    Console.Write("Radius: ");
                    double radius = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
