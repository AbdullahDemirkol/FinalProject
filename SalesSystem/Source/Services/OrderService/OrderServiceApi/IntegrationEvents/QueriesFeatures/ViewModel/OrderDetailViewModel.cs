using OrderServiceApi.Entity.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel
{
    public class OrderDetailViewModel
    {
        public Guid OrderNumber { get; init; }
        public DateTime Date { get; init; }
        public string Status { get; set; }
        public string Description { get; init; }
        public string Neighbourhood { get; init; }
        public string Street { get; init; }
        public string BuildingNo { get; set; }
        public string ApartmentNo { get; set; }
        public string District { get; init; }
        public string City { get; init; }
        public string ZipCode { get; init; }
        public string Country { get; init; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal Total { get; set; }
        public string BuyerName { get; set; }
        public string PaymentMethodPrefix { get; set; }
        public string PaymentMethodSuffix { get; set; }

    }
}
