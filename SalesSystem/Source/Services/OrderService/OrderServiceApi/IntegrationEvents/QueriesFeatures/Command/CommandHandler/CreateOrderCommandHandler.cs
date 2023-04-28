using EventBus.Base.EventBus.Abstract;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.Events;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.CommandHandler
{

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IEventBus _eventBus;
        private IServiceScopeFactory _serviceScopeFactory;
        public CreateOrderCommandHandler(IServiceScopeFactory serviceScopeFactory, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _serviceScopeFactory = serviceScopeFactory;

        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;

                var _orderRepository = scopedServices.GetRequiredService<IOrderRepository>();

                var address = new Address(request.Neighbourhood, request.Street, request.BuildingNo,request.ApartmentNo,request.District, request.City, request.Country, request.ZipCode);
                Order dbOrder = new Order(request, address/*, null*/);
                foreach (var orderItem in request.OrderItems.ToList())
                {
                    dbOrder.AddOrderItem(orderItem);
                }
                await _orderRepository.AddAsync(dbOrder);

                //await _orderRepository.AddAsync(dbOrder);
                await _orderRepository.UnitOfWork.SaveEntityAsync(cancellationToken);
                var orderStartedIntegrationEvent = new OrderStartedIntegrationEvent(request.UserName);
                dbOrder.Address.BuyerId = dbOrder.BuyerId;
                _eventBus.Publish(orderStartedIntegrationEvent);
            }
            return true;

        }
    }
}
