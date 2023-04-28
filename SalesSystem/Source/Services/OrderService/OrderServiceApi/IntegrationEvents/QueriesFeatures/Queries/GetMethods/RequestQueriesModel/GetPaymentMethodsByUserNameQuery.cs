using MediatR;
using OrderServiceApi.Entity.Concrete.Buyer;
using ProductServiceApi.Entity.Concrete.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel
{

    public class GetPaymentMethodsByUserNameQuery : IRequest<PaginatedViewModel<PaymentMethod>>
    {
        public string BuyerName { get; set; }
        public int CardTypeId { get; set; } = 0;
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public GetPaymentMethodsByUserNameQuery(string buyerName, int cardTypeId, int pageSize, int pageIndex)
        {
            BuyerName = buyerName;
            CardTypeId = cardTypeId;
            PageSize = pageSize;
            PageIndex = pageIndex;
        }
    }
}
