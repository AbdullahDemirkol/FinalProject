using EventBus.Base.Entity.Abstract;
using EventBus.Base.Entity.Concrete;
using EventBus.Base.EventBus.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PaymentServiceApi.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.IntegrationEvents.EventHandlers
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {

        private readonly IConfiguration _configuration;
        private readonly ILogger<OrderStartedIntegrationEventHandler> _logger;
        private readonly IEventBus _eventBus;

        public OrderStartedIntegrationEventHandler(IConfiguration configuration, ILogger<OrderStartedIntegrationEventHandler> logger, IEventBus eventBus)
        {
            _configuration = configuration;
            _logger = logger;
            _eventBus = eventBus;
        }

        public Task Handle(OrderStartedIntegrationEvent integrationEvent)
        {
            _logger.LogInformation($"Ödeme işlemi başlatıldı.");
            //Fake ödeme yöntemi
            string keyword = "PaymentSuccess";
            bool paymentSuccess = _configuration.GetValue<bool>(keyword);
            IntegrationEvent paymentEvent;

            if (paymentSuccess)
            {
                paymentEvent = new OrderPaymentSuccessIntegrationEvent(integrationEvent.OrderId, $"Ödeme işlemi başarılı oldu.");
            }
            else
            {
                paymentEvent = new OrderPaymentFailedIntegrationEvent(integrationEvent.OrderId, $"Ödeme işlemi başarısız oldu.");
            }
            _logger.LogInformation($"Ödeme işlemi yapıldı. PaymentService:{paymentSuccess},orderId:{integrationEvent.OrderId}");
            _eventBus.Publish(paymentEvent);
            return Task.CompletedTask;

        }
    }
}
