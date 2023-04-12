using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.CommandHandler
{
    public class UpdatePaymentMethodCommandHandler : IRequestHandler<UpdatePaymentMethodCommand, (bool, string)>
    {
        IPaymentMethodRepository _paymentMethodRepository;
        IBuyerRepository _buyerRepository;

        public UpdatePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IBuyerRepository buyerRepository)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
        }

        public async Task<(bool, string)> Handle(UpdatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _paymentMethodRepository.GetByIdAsync(request.PaymentMethodId);
            paymentMethod.Status = false;
            _paymentMethodRepository.Update(paymentMethod);
            await _paymentMethodRepository.UnitOfWork.SaveEntityAsync(cancellationToken);
            var buyer= _buyerRepository.GetById(paymentMethod.BuyerId).Result.Name;
            return (true, buyer);
        }
    }
}
