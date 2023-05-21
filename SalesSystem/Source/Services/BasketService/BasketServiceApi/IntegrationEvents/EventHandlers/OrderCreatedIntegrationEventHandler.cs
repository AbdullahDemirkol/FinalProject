using BasketServiceApi.Business.Abstract;
using BasketServiceApi.DataAccess.Abstract;
using BasketServiceApi.IntegrationEvents.Events;
using EventBus.Base.Entity.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.IntegrationEvents.EventHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        //IBasketRepository yada IBasketService kullanabilirsin
        //private readonly IBasketService _basketRepository;
        private IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<OrderCreatedIntegrationEvent> _logger;

        public OrderCreatedIntegrationEventHandler(IServiceScopeFactory serviceScopeFactory, ILogger<OrderCreatedIntegrationEvent> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        public async Task Handle(OrderCreatedIntegrationEvent integrationEvent)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;

                var _basketRepository = scopedServices.GetRequiredService<IBasketService>();
                _logger.LogInformation("Sipariş tamamlama işlemi devam ediyor: {IntegrationEventId}(IntegrationEventId) BasketServiceApi - ({@IntegrationEvent})", integrationEvent.Id, integrationEvent);
                await _basketRepository.DeleteBasketAsync(integrationEvent.Username);
            }
        }
    }
}
