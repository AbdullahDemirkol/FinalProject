using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IOrderService
    {
        BasketDTO MapOrderToBasket(Order order);
        Task<List<OrderDTO>> GetOrders(int orderStatusId);
        Task<List<OrderDTO>> GetOrdersDetailByBuyerName(string buyerName, int orderStatusId);
        Task<List<PaymentMethod>> GetPaymentMethodsDetailByBuyerName(string buyerName, int cardTypeId);
        Task<List<OrderDTO>> CancelOrderStatus(Guid orderNumber);
        Task<List<PaymentMethod>> CancelPaymentMethod(Guid paymentMethodId);
        Task<List<PaymentMethod>> AddPaymentMethod(PaymentMethod paymentMethod, string userName);
        Task<List<OrderStatus>> GetOrderStatuses();
        Task<List<CardType>> GetCardTypes();
    }
}
