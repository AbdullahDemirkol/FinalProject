using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Business.Abstract;
using WebApplicationAdminPanel.Entity.Concrete;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Helper;
using WebApplicationAdminPanel.Extensions.ClientHttp;

namespace WebApplicationAdminPanel.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly HttpClient apiClient;
        private readonly IIdentityService identityService;
        private readonly ILogger<OrderManager> logger;

        public OrderManager(HttpClient apiClient, IIdentityService identityService, ILogger<OrderManager> logger)
        {
            this.apiClient = apiClient;
            this.identityService = identityService;
            this.logger = logger;
        }

        public async void SetOrderStatus(OrderDTO orderDTO, int statusId)
        {
            var query = $"order/setOrderStatus/{statusId}/buyerName/{orderDTO.BuyerName}";
            await apiClient.PostAsync<Guid>(query, orderDTO.OrderNumber);
        }
        public async Task<PaginatedViewModel<OrderDTO>> GetOrders(int orderStatusId, int pageIndex, int pageSize=6)
        {
            var query = $"order/orders/{orderStatusId}?pageIndex={pageIndex}&pageSize={pageSize}";
            var orders = await apiClient.GetResponseAsync<PaginatedViewModel<OrderDTO>>(query);
            return orders;
        }
        public async Task<List<OrderStatus>> GetOrderStatuses()
        {
            var query = "order/orderStatuses";
            var orderStatuses = await apiClient.GetResponseAsync<List<OrderStatus>>(query);
            foreach (var orderStatus in orderStatuses)
            {
                if (orderStatus.Name == "islemealinildi")
                {
                    orderStatus.Name = "İşleme Alınıldı";
                }
                else if (orderStatus.Name == "dogrulamabekleniyor")
                {
                    orderStatus.Name = "Doğrulama Bekleniyor";
                }
                else if (orderStatus.Name == "stokonaylandi")
                {
                    orderStatus.Name = "Stok Onaylandı";
                }
                else if (orderStatus.Name == "odenildi")
                {
                    orderStatus.Name = "Ödenildi";
                }
                else if (orderStatus.Name == "gonderildi")
                {
                    orderStatus.Name = "Gönderildi";
                }
                else if (orderStatus.Name == "iptaledildi")
                {
                    orderStatus.Name = "İptal Edildi";
                }
            }
            return orderStatuses;
        }
    }
}
