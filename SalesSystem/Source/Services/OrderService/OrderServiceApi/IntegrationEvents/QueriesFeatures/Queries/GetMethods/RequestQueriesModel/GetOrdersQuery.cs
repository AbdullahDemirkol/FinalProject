using MediatR;
using OrderServiceApi.Entity.Concrete.Helper;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel
{
    public class GetOrdersQuery : IRequest<PaginatedViewModel<OrderDetailViewModel>>
    {
        public int OrderStatusId { get; set; } = 0;
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public GetOrdersQuery(int orderStatusId, int pageSize, int pageIndex)
        {
            OrderStatusId = orderStatusId;
            PageSize = pageSize;
            PageIndex = pageIndex;
        }
    }
}
