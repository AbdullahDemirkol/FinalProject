﻿using MediatR;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.QueryHandlers
{

    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<OrderDetailViewModel>>
    {
        IOrderRepository _orderRepository;
        IPaymentMethodRepository _paymentMethodRepository;

        public GetOrdersQueryHandler(IOrderRepository orderRepository, IPaymentMethodRepository paymentMethodRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
        }

        public async Task<List<OrderDetailViewModel>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            List<Order> orders = new List<Order>();
            if (request.OrderStatusId == 0)
            {
                orders = await _orderRepository.Get(null, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer);
            }
            else
            {
                orders = await _orderRepository.Get(p => p.OrderStatus.Id == request.OrderStatusId, orderBy: i => i.OrderByDescending(p => p.OrderDate), i => i.OrderItems, p => p.OrderStatus, p => p.Address, p => p.Buyer);
            }
            List<OrderDetailViewModel> orderDetailViewModels = new List<OrderDetailViewModel>();
            foreach (var order in orders)
            {
                var paymentMethodCardNumber = _paymentMethodRepository.GetSingleAsync(p => p.Id == order.PaymentMethodId).Result.CardNumber;
                var orderDetailViewModel = new OrderDetailViewModel()
                {
                    Neighbourhood = order.Address.Neighbourhood,
                    Street = order.Address.Street,
                    BuildingNo = order.Address.BuildingNo,
                    ApartmentNo = order.Address.ApartmentNo,
                    District = order.Address.District,
                    City = order.Address.City,
                    Country = order.Address.Country,
                    Description = order.Description,
                    OrderItems = (List<OrderItem>)order.OrderItems,
                    OrderNumber = order.Id,
                    Status = order.OrderStatus.Name,
                    ZipCode = order.Address.ZipCode,
                    Total = order.Total(),
                    Date = order.OrderDate,
                    BuyerName = order.Buyer.Name,
                    PaymentMethodPrefix = paymentMethodCardNumber.Substring(0, 4),
                    PaymentMethodSuffix = paymentMethodCardNumber.Substring(paymentMethodCardNumber.Length - 4)
                };
                orderDetailViewModels.Add(orderDetailViewModel);
            }
            return orderDetailViewModels;
        }
    }
}
