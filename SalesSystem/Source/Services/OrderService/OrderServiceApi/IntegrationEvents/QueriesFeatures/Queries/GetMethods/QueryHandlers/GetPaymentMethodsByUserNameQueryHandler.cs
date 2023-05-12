using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Helper;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.QueryHandlers
{

    public class GetPaymentMethodsByUserNameQueryHandler  : IRequestHandler<GetPaymentMethodsByUserNameQuery, PaginatedViewModel<PaymentMethod>>
    {
        IBuyerRepository _buyerRepository;
        IPaymentMethodRepository _paymentMethodRepository;

        public GetPaymentMethodsByUserNameQueryHandler(IPaymentMethodRepository paymentMethodRepository, IBuyerRepository buyerRepository)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
        }

        public async Task<PaginatedViewModel<PaymentMethod>> Handle(GetPaymentMethodsByUserNameQuery request, CancellationToken cancellationToken)
        {
            var buyer = await _buyerRepository.GetSingleAsync(p => p.Name == request.BuyerName);
            int paymentMethodCount = 0;
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();
            if (buyer != null)
            {
                if (request.CardTypeId == 0 && buyer != null)
                {
                    paymentMethods = await _paymentMethodRepository.Get(p => p.BuyerId == buyer.Id && p.Status == true, i => i.CardType);
                }
                else if (buyer != null)
                {
                    paymentMethods = await _paymentMethodRepository.Get(p => p.BuyerId == buyer.Id && p.CardType.Id == request.CardTypeId && p.Status == true, i => i.CardType);
                }
                paymentMethodCount = paymentMethods.Count();
                paymentMethods = paymentMethods.Skip(request.PageSize * request.PageIndex).Take(request.PageSize).ToList();
            }
            var model = new PaginatedViewModel<PaymentMethod>(request.PageIndex, request.PageSize, (int)paymentMethodCount, paymentMethods);
            return model;
        }
    }
}
