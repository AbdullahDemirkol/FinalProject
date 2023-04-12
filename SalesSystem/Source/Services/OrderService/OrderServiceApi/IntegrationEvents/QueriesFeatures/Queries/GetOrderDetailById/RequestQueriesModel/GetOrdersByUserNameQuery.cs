using MediatR;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.Queries
{
    public class GetOrdersByUserNameQuery : IRequest<List<OrderDetailViewModel>>
    {
        public string BuyerName { get; set; }
        public int OrderStatusId { get; set; } = 0;

        public GetOrdersByUserNameQuery(string buyerName, int orderStatusId)
        {
            BuyerName = buyerName;
            OrderStatusId = orderStatusId;
        }
    }
}
