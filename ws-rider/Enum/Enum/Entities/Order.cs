using System;
using Enum.Entities.Enums;

namespace Enum.Entities {
    public class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return string.Format("| Id: {0} | Date: {1} | Status: {2} |", Id, Moment, Status);
        }
    }
}
