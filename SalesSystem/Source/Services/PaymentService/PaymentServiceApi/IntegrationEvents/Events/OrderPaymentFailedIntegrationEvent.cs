using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.IntegrationEvents.Events
{
    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public int OrderId;
        public string FailedMessage;

        public OrderPaymentFailedIntegrationEvent(int orderId, string failedMessage)
        {
            OrderId = orderId;
            FailedMessage = failedMessage;
        }
    }
}
