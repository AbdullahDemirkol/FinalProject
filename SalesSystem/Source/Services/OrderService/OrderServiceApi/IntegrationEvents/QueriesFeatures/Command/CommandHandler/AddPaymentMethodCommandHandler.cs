﻿using MediatR;
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

    public class AddPaymentMethodCommandHandler : IRequestHandler<AddPaymentMethodCommand, bool>
    {
        IPaymentMethodRepository _paymentMethodRepository;
        IBuyerRepository _buyerRepository;

        public AddPaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IBuyerRepository buyerRepository)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
        }

        public async Task<bool> Handle(AddPaymentMethodCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newPaymentMethod = new PaymentMethod(request.PaymentMethod.Alias, request.PaymentMethod.CardNumber, request.PaymentMethod.SecurityNumber, request.PaymentMethod.CardHolderName, request.PaymentMethod.Expiration, request.PaymentMethod.CardTypeId);
                var buyer = _buyerRepository.GetSingleAsync(p => p.Name == request.UserName, p => p._paymentMethods.Where(p=>p.Status==true)).Result;
                newPaymentMethod.CardTypeId = (newPaymentMethod.CardTypeId != 0) ? newPaymentMethod.CardTypeId : 1;

                foreach (var paymentMethod in buyer._paymentMethods)
                {
                    bool equalPaymentMethod = newPaymentMethod.IsEqualPaymentMethod(paymentMethod.CardTypeId, paymentMethod.CardNumber, paymentMethod.CardHolderName, paymentMethod.Expiration);
                    if (equalPaymentMethod)
                    {
                        return false;
                    }
                }
                newPaymentMethod.BuyerId = buyer.Id;
                newPaymentMethod.Alias = $"{DateTime.UtcNow} Tarihte Ekleme Yapıldı.";
                newPaymentMethod.Status = true;
                buyer._paymentMethods.Add(newPaymentMethod);

                await _paymentMethodRepository.AddAsync(newPaymentMethod);
                await _buyerRepository.UnitOfWork.SaveEntityAsync(cancellationToken);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
