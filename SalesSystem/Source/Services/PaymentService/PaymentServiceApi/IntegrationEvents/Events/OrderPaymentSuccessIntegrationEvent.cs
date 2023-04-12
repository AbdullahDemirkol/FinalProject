using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.IntegrationEvents.Events
{
    public class OrderPaymentSuccessIntegrationEvent : IntegrationEvent
    {
        public int OrderId;
        public string SuccessMessage;

        public OrderPaymentSuccessIntegrationEvent(int orderId, string successMessage)
        {
            OrderId = orderId;
            SuccessMessage = successMessage;
        }
    }
}
