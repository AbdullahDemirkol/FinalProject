using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entity.Concrete;
using WebApplication.Entity.Concrete.Basket.Buyer;
using WebApplication.Entity.Concrete.Basket.Order;
using WebApplication.Entity.Concrete.DTOs;
using WebApplication.Entity.Concrete.Helper;

namespace WebApplication.Business.Abstract
{
    public interface IOrderService
    {
        Task<PaginatedViewModel<OrderDTO>> GetOrdersDetailByBuyerName(string buyerName, int orderStatusId, int pageIndex);
        Task<PaginatedViewModel<PaymentMethod>> GetPaymentMethodsDetailByBuyerName(string buyerName, int cardTypeId,int pageIndex);
        Task CancelOrderStatus(Guid orderNumber,string buyerName);
        Task CancelPaymentMethod(Guid paymentMethodId, string buyerName);
        Task<string> AddPaymentMethodByBuyerName(PaymentMethod paymentMethod, string userName);
        Task<List<OrderStatus>> GetOrderStatuses();
        Task<List<CardType>> GetCardTypes();
    }
}
