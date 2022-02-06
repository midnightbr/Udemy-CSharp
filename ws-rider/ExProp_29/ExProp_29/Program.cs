using System;
using System.Globalization;
using ExProp_29.Entities;
using ExProp_29.Entities.Enums;

namespace ExProp_29 {
    class Program {
        static void Main(string[] args) {
            // Client
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);
            
            // Order
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            
            // Quantity
            Console.Write("How many items to this order? ");
            int qtdOrder = int.Parse(Console.ReadLine());
            // Products
            for (int i = 1; i <= qtdOrder; i++) {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string namePro = Console.ReadLine();
                Console.Write("Product price: $");
                double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(namePro, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                
                order.AddItem(orderItem);

                Console.WriteLine();
            }

            Console.WriteLine(order);
        }
    }
}
