using MediatR;
using Microsoft.Extensions.Logging;
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
    public class UpdatePaymentMethodCommandHandler : IRequestHandler<UpdatePaymentMethodCommand, bool>
    {
        IPaymentMethodRepository _paymentMethodRepository;
        IBuyerRepository _buyerRepository;
        ILogger<UpdatePaymentMethodCommandHandler> _logger;

        public UpdatePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IBuyerRepository buyerRepository, ILogger<UpdatePaymentMethodCommandHandler> logger)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
            _logger = logger;
        }

        public async Task<bool> Handle(UpdatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var paymentMethod = await _paymentMethodRepository.GetByIdAsync(request.PaymentMethodId);
                var buyers = _buyerRepository.GetSingleAsync(p => p.Name == request.BuyerName && p.Id == paymentMethod.BuyerId).Result.Name;
                if (buyers != null)
                {
                    paymentMethod.Status = false;
                    _paymentMethodRepository.Update(paymentMethod);
                    await _paymentMethodRepository.UnitOfWork.SaveEntityAsync(cancellationToken);
                    _logger.LogInformation($"{request.PaymentMethodId} numaralı ödeme yöntemi değiştirildi.");
                    return true;
                }
                _logger.LogInformation($"{request.PaymentMethodId} numaralı ödeme yöntemi değiştirilemedi.");
                return false;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"{request.PaymentMethodId} numaralı ödeme yöntemi değiştirilemedi. Hata Mesajı: {e.Message}");
                return false;
            }

        }
    }
}
