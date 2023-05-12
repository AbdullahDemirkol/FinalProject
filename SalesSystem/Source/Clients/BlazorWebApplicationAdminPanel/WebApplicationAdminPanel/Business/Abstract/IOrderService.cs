using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Helper;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IOrderService
    {
        Task<PaginatedViewModel<OrderDTO>> GetOrders(int orderStatusId, int pageIndex, int pageSize=6);
        Task<List<OrderStatus>> GetOrderStatuses();
        void SetOrderStatus(OrderDTO orderDTO,int statusId);
    }
}
