using System;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Convertendo de Enumerado para String
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            
            // Convertendo de String para Enumerado
            OrderStatus os = System.Enum.Parse<OrderStatus>("Delivered"); 
            // O nome em string tem que ser o mesmo já cadastrado no enum anteriormente
            Console.WriteLine(os);
        }
    }
}
