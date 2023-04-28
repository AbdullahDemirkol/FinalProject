
using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.Queries;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.QueryHandlers
{
    public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery, OrderDetailViewModel>
    {
        IOrderRepository _orderRepository;
        //private readonly IMapper mapper;

        public GetOrderDetailsQueryHandler(IOrderRepository orderRepository/*, IMapper mapper*/)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            //this.mapper = mapper;
        }

        public async Task<OrderDetailViewModel> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderId, i => i.OrderItems);
            var orderDetailViewModel = new OrderDetailViewModel()
            {
                City = order.Address.City,
                Country = order.Address.Country
            };
            //var result = mapper.Map<OrderDetailViewModel>(order);
            return orderDetailViewModel;
        }
    }
}
