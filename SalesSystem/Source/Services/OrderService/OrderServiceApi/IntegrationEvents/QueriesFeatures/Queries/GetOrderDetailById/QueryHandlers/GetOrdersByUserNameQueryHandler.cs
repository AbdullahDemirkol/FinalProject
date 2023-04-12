
using MediatR;
using OrderServiceApi.DataAccess;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.Queries;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.QueryHandlers
{
    public class GetOrdersByUserNameQueryHandler : IRequestHandler<GetOrdersByUserNameQuery, List<OrderDetailViewModel>>
    {
        IOrderRepository _orderRepository;
        IBuyerRepository _buyerRepository;
        IPaymentMethodRepository _paymentMethodRepository;

        public GetOrdersByUserNameQueryHandler(IOrderRepository orderRepository, IBuyerRepository buyerRepository, IPaymentMethodRepository paymentMethodRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
        }

        public async Task<List<OrderDetailViewModel>> Handle(GetOrdersByUserNameQuery request, CancellationToken cancellationToken)
        {
            var buyer= await _buyerRepository.GetSingleAsync(p => p.Name == request.BuyerName,p=>p._paymentMethods);
            List<Order> orders=new List<Order>();
            if (request.OrderStatusId==0)
            {
                orders = await _orderRepository.Get(p => p.BuyerId == buyer.Id, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer,p=>p.Buyer);
            }
            else 
            {
                orders = await _orderRepository.Get(p => p.BuyerId == buyer.Id&&p.OrderStatus.Id==request.OrderStatusId, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer);
            }
            List<OrderDetailViewModel> orderDetailViewModels = new List<OrderDetailViewModel>();
            foreach (var order in orders)
            {
                var paymentMethodCardNumber = _paymentMethodRepository.GetSingleAsync(p=>p.Id==order.PaymentMethodId).Result.CardNumber;
                var orderDetailViewModel = new OrderDetailViewModel()
                {
                    State = order.Address.State,
                    Street = order.Address.Street,
                    City = order.Address.City,
                    Country = order.Address.Country,
                    Description=order.Description,
                    OrderItems=(List<OrderItem>)order.OrderItems,
                    OrderNumber=order.Id,
                    Status=order.OrderStatus.Name,
                    ZipCode=order.Address.ZipCode,
                    Total=order.Total(),
                    Date=order.OrderDate,
                    BuyerName=order.Buyer.Name,
                    PaymentMethodPrefix= paymentMethodCardNumber.Substring(0, 4),
                    PaymentMethodSuffix = paymentMethodCardNumber.Substring(paymentMethodCardNumber.Length - 4)
                };
                orderDetailViewModels.Add(orderDetailViewModel);
            }
            return orderDetailViewModels;
        }
    }
}
