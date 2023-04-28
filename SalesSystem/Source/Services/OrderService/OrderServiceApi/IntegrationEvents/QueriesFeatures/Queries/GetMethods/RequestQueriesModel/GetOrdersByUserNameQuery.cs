using MediatR;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using ProductServiceApi.Entity.Concrete.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.Queries
{
    public class GetOrdersByUserNameQuery : IRequest<PaginatedViewModel<OrderDetailViewModel>>
    {
        public string BuyerName { get; set; }
        public int OrderStatusId { get; set; } = 0;
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public GetOrdersByUserNameQuery(string buyerName, int orderStatusId, int pageSize, int pageIndex)
        {
            BuyerName = buyerName;
            OrderStatusId = orderStatusId;
            PageSize = pageSize;
            PageIndex = pageIndex;
        }
    }
}
