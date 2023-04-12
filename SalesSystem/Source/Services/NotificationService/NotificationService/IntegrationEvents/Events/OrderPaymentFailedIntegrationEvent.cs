using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.Events
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
