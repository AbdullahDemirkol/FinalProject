using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public OrderStartedIntegrationEvent(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
