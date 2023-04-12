using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Basket.Order
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public Buyer.Buyer Buyer { get; set; }

        public readonly List<OrderItem> _orderItems;

    }
}
