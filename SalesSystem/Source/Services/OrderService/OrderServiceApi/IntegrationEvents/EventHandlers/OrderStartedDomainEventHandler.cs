using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.DataAccess.Repositories.Concrete;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.EventHandlers
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository, IPaymentMethodRepository paymentMethodRepository)
        {
            _buyerRepository = buyerRepository;
            _paymentMethodRepository = paymentMethodRepository;
        }

        public async Task Handle(OrderStartedDomainEvent orderStartedDomainEvent, CancellationToken cancellationToken)
        {
            var cardTypeId = (orderStartedDomainEvent.CardTypeId != 0) ? orderStartedDomainEvent.CardTypeId : 1;
            var buyer = await _buyerRepository.GetSingleAsync(i => i.Name == orderStartedDomainEvent.UserName,p=>p._paymentMethods);
            bool buyerOriginallyExisted = buyer != null;
            if (!buyerOriginallyExisted)
            {
                buyer = new Buyer(orderStartedDomainEvent.UserName);
            }
            var paymentMethods = buyer._paymentMethods;  

            var (responseInsert,paymentMethod)=buyer.VerifyOrAddPaymentMethod(orderStartedDomainEvent, cardTypeId, $"Payment Method on {DateTime.UtcNow}");
            if (!buyerOriginallyExisted)
            {
                await _buyerRepository.AddAsync(buyer);
            }
            else
            {

                if (responseInsert)
                {
                    await _paymentMethodRepository.AddAsync(paymentMethod);
                }
            }
            await _buyerRepository.UnitOfWork.SaveEntityAsync(cancellationToken);

        }
    }
}
