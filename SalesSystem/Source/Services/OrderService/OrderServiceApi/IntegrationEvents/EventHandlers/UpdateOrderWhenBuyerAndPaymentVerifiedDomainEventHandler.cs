using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.EventHandlers
{
    public class UpdateOrderWhenBuyerAndPaymentVerifiedDomainEventHandler : INotificationHandler<BuyerAndPaymentVerifiedDomainEvent>
    {
        private readonly IOrderRepository _orderRepository;

        public UpdateOrderWhenBuyerAndPaymentVerifiedDomainEventHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        public async Task Handle(BuyerAndPaymentVerifiedDomainEvent buyerAndPaymentVerifiedDomainEvent, CancellationToken cancellationToken)
        {
            var orderToUpdate = await _orderRepository.GetByIdAsync(buyerAndPaymentVerifiedDomainEvent.OrderId);
            orderToUpdate.SetBuyerId(buyerAndPaymentVerifiedDomainEvent.Buyer.Id);
            orderToUpdate.SetPaymentMethodId(buyerAndPaymentVerifiedDomainEvent.Payment.Id);
            await _orderRepository.UnitOfWork.SaveChangesAsync();
        }

    }
}
