using EventBus.Base.Entity.Abstract;
using MediatR;
using Microsoft.Extensions.Logging;
using OrderServiceApi.IntegrationEvents.Events;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.EventHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrderCreatedIntegrationEventHandler> _logger;

        public OrderCreatedIntegrationEventHandler(IMediator mediator, ILogger<OrderCreatedIntegrationEventHandler> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task Handle(OrderCreatedIntegrationEvent integrationEvent)
        {
            _logger.LogInformation("Handling integration event:{IntegrationEventId} at {AppName}-({IntegrationEvent})", integrationEvent.Id, typeof(Startup).Namespace, integrationEvent);
            var createordercommand = new CreateOrderCommand(integrationEvent.BasketCardInformationItem, integrationEvent.CustomerBasket);
            await _mediator.Send(createordercommand);

        }
    }
}
