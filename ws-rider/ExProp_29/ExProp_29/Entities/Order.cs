using System;
using System.Collections.Generic;
using System.Text;
using ExProp_29.Entities.Enums;

namespace ExProp_29.Entities {
    public class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("ORDER SUMMARY");
            builder.AppendLine($"Order moment: {Moment}");
            builder.AppendLine($"Order status: {Status}");
            builder.AppendLine($"Client: {Client.Name} {Client.BirthDate.ToShortDateString()} - {Client.Email}");
            builder.AppendLine("Order items");
            foreach (OrderItem items in Items) {
                builder.AppendLine($"{items.Product.Name}, ${items.Price}, " +
                                   $"Quantity: {items.Quantity}, Subtotal: ${items.SubTotal()}");
            }

            builder.AppendLine($"Total price: ${Total()}");

            return builder.ToString();
        }
    }
}
