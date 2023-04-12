using MediatR;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.RequestQueriesModel
{

    public class GetPaymentMethodsByUserNameQuery : IRequest<List<PaymentMethod>>
    {
        public string BuyerName { get; set; }
        public int CardTypeId { get; set; } = 0;

        public GetPaymentMethodsByUserNameQuery(string buyerName, int cardTypeId)
        {
            BuyerName = buyerName;
            CardTypeId = cardTypeId;
        }
    }
}
