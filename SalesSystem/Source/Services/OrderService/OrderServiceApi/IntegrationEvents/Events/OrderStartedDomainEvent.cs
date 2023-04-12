using MediatR;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; }
        public int CardTypeId { get; }
        public string CardNumber { get; }
        public string CardSecurityNumber { get; }
        public string CardHolderName { get; }
        public DateTime CardExpiration { get; }
        public Order Order { get; }
        public OrderStartedDomainEvent(CreateOrderCommand createOrderCommand, Order order)
        {
            UserName = createOrderCommand.UserName;
            CardTypeId = createOrderCommand.CardTypeId;
            CardNumber = createOrderCommand.CardNumber;
            CardSecurityNumber = createOrderCommand.CardSecurityNumber;
            CardHolderName = createOrderCommand.CardHolderName;
            CardExpiration = createOrderCommand.CardExpiration;
            Order = order;
        }
    }
}
