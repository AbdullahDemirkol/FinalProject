using EventBus.Base.Entity.Abstract;
using Microsoft.Extensions.Logging;
using NotificationService.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.IntegrationEvents.EventHandlers
{

    class OrderPaymentFailedIntegrationEventHandler : IIntegrationEventHandler<OrderPaymentFailedIntegrationEvent>
    {
        private readonly ILogger<OrderPaymentFailedIntegrationEvent> _logger;

        public OrderPaymentFailedIntegrationEventHandler(ILogger<OrderPaymentFailedIntegrationEvent> logger)
        {
            _logger = logger;
        }

        public Task Handle(OrderPaymentFailedIntegrationEvent integrationEvent)
        {
            // Send email and sms service
            _logger.LogInformation($"Ödeme işlemi başarısız. OrderId:{integrationEvent.OrderId}, Message:{integrationEvent.FailedMessage}");
            return Task.CompletedTask;
        }
    }
}
