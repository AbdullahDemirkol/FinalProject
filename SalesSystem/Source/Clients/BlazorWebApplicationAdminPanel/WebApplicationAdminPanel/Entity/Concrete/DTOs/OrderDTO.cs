using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

namespace WebApplicationAdminPanel.Entity.Concrete.DTOs
{
    public class OrderDTO
    {
        public OrderDTO()
        {

        }
        public Guid OrderNumber { get; init; }
        public DateTime Date { get; init; }
        public string Status { get; set; }
        public string Description { get; init; }
        public string State { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public string ZipCode { get; init; }
        public string Country { get; init; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal Total { get; set; }
        public string BuyerName { get; set; }
        public string PaymentMethodPrefix { get; set; }
        public string PaymentMethodSuffix { get; set; }
        public int OrderItemCount()
        {
            var orderCount = 0;
            foreach (var orderItem in OrderItems)
            {
                orderCount += orderItem.Units;
            }
            return orderCount;
        }
    }
}
