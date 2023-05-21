using EventBus.Base.EventBus.Abstract;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.CommandHandler
{
    public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, bool>
    {
        IOrderRepository _orderRepository;
        ILogger<UpdateOrderStatusCommandHandler> _logger;

        public UpdateOrderStatusCommandHandler(IOrderRepository orderRepository, ILogger<UpdateOrderStatusCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _logger = logger;
        }

        public async Task<bool> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderNumber, p => p.OrderStatus, p => p.Buyer);
            if (order.Buyer.Name == request.BuyerName)
            {
                order.SetOrderStatus(request.OrderStatusId);
                _orderRepository.Update(order);
                await _orderRepository.UnitOfWork.SaveEntityAsync(cancellationToken);
                _logger.LogInformation($"{request.OrderNumber} numaralı siparişin statüsü değiştirildi.");
                return true;
            }
            _logger.LogInformation($"{request.OrderNumber} numaralı siparişin statüsü değiştirilemedi.");
            return false;
        }
    }
}
