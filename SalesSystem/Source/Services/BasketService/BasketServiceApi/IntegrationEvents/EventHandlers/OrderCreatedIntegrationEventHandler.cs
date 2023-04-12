using BasketServiceApi.DataAccess.Abstract;
using BasketServiceApi.IntegrationEvents.Events;
using EventBus.Base.Entity.Abstract;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.IntegrationEvents.EventHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly ILogger<OrderCreatedIntegrationEvent> _logger;

        public OrderCreatedIntegrationEventHandler(IBasketRepository basketRepository, ILogger<OrderCreatedIntegrationEvent> logger)
        {
            _basketRepository = basketRepository;
            _logger = logger;
        }

        public async Task Handle(OrderCreatedIntegrationEvent integrationEvent)
        {
            _logger.LogInformation(" Entegrasyon işlemi devam ediyor: {IntegrationEventId}(IntegrationEventId) BasketServiceApi - ({@IntegrationEvent})", integrationEvent.Id,integrationEvent);
            await _basketRepository.DeleteBasketAsync(integrationEvent.Username);
        }
    }
}
