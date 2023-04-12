using OrderServiceApi.Entity.Concrete.Base;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.IntegrationEvents.Events;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Order
{

    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public Buyer.Buyer Buyer { get; private set; }
        public Address Address { get; private set; }
        private int orderStatusId;
        public OrderStatus OrderStatus { get; private set; }
        private readonly List<OrderItem> _orderItems;
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;
        public Guid BuyerId { get; private set; }
        public Guid? PaymentMethodId { get; set; }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var order in OrderItems)
            {
                total += (order.Units * order.UnitPrice);
            }
            return total;
        }
        protected Order()
        {
            Id = Guid.NewGuid();
            _orderItems = new List<OrderItem>();
        }

        public Order(CreateOrderCommand basketCardInformationItem, Address address ) : this()
        {
            //BuyerId = buyerId;
            orderStatusId = OrderStatus.IslemeAlinildi.Id;
            OrderDate = DateTime.UtcNow;
            Address = address;
            //PaymentMethodId = paymentMethodId;
            AddOrderStartedDomainEvent(basketCardInformationItem);

        }

        private void AddOrderStartedDomainEvent(CreateOrderCommand basketCardInformationItem)
        {
            var orderStartedDomainEvent = new OrderStartedDomainEvent(basketCardInformationItem, this);
            //var orderStartedDomainEvent = new OrderStartedDomainEvent(this, userName, cardTypeId,)
            AddDomainEvent(orderStartedDomainEvent);
        }
        public void AddOrderItem(OrderItem orderItem)
        {
            var addOrderItem = new OrderItem(orderItem.ProductId, orderItem.ProductName, orderItem.PictureUrl,orderItem.UnitPrice, orderItem.Units);
            _orderItems.Add(addOrderItem);
        }
        public void SetOrderStatus(int id)
        {
            OrderStatus = OrderStatus.FromId(id);
        }
        public void SetBuyerId(Guid buyerId)
        {
            BuyerId = buyerId;
            Address.BuyerId = buyerId;
        }
        public void SetPaymentMethodId(Guid paymentMethodId)
        {
            PaymentMethodId = paymentMethodId;
        }
    }
}
