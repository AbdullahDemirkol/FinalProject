using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.IntegrationEvents.Events
{
    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId;
        public string FailedMessage;

        public OrderPaymentFailedIntegrationEvent(Guid orderId, string failedMessage)
        {
            OrderId = orderId;
            FailedMessage = failedMessage;
        }
    }
}
