
using MediatR;
using OrderServiceApi.DataAccess;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Helper;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.Queries;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.QueryHandlers
{
    public class GetOrdersByUserNameQueryHandler : IRequestHandler<GetOrdersByUserNameQuery, PaginatedViewModel<OrderDetailViewModel>>
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

        public async Task<PaginatedViewModel<OrderDetailViewModel>> Handle(GetOrdersByUserNameQuery request, CancellationToken cancellationToken)
        {
            var buyer= await _buyerRepository.GetSingleAsync(p => p.Name == request.BuyerName,p=>p._paymentMethods);
            int orderCount = 0;
            List<Order> orders=new List<Order>();
            if (buyer!=null)
            {
                if (request.OrderStatusId == 0)
                {
                    orders = await _orderRepository.Get(p => p.BuyerId == buyer.Id, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer, p => p.Buyer);
                    
                }
                else
                {
                    orders = await _orderRepository.Get(p => p.BuyerId == buyer.Id && p.OrderStatus.Id == request.OrderStatusId, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer);

                }
                orderCount = orders.Count();
                orders = orders.Skip(request.PageSize * request.PageIndex).Take(request.PageSize).ToList();

            }
            List<OrderDetailViewModel> orderDetailViewModels = new List<OrderDetailViewModel>();
            //var ordersList = (List<Order>)orders;
            foreach (var order in orders)
            {
                var paymentMethodCardNumber = _paymentMethodRepository.GetSingleAsync(p=>p.Id==order.PaymentMethodId).Result.CardNumber;
                var orderDetailViewModel = new OrderDetailViewModel()
                {
                    Neighbourhood=order.Address.Neighbourhood,
                    Street = order.Address.Street,
                    BuildingNo = order.Address.BuildingNo,
                    ApartmentNo = order.Address.ApartmentNo,
                    District = order.Address.District,
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
            var model = new PaginatedViewModel<OrderDetailViewModel>(request.PageIndex,request.PageSize,(int)orderCount, orderDetailViewModels);
            return model;
        }
    }
}
