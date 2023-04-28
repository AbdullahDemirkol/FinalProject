using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Business.Abstract;
using WebApplication.Entity.Concrete;
using WebApplication.Entity.Concrete.Basket.Buyer;
using WebApplication.Entity.Concrete.Basket.Order;
using WebApplication.Entity.Concrete.DTOs;
using WebApplication.Entity.Concrete.Helper;
using WebApplication.Extensions.ClientHttp;

namespace WebApplication.Business.Concrete
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
        public async Task<PaginatedViewModel<OrderDTO>> GetOrdersDetailByBuyerName(string buyerName,int orderStatusId,int pageIndex=0)
        {

            var query = "order/" + buyerName+ "/OrderStatus/" + orderStatusId+"?pageIndex="+pageIndex;
            var orders = await apiClient.GetResponseAsync<PaginatedViewModel<OrderDTO>>(query);
            return orders;
        }
        public async Task<PaginatedViewModel<PaymentMethod>> GetPaymentMethodsDetailByBuyerName(string buyerName, int cardTypeId,int pageIndex=0)
        {
            var query = "paymentMethod/" + buyerName + "/CardType/" + cardTypeId + "?pageIndex=" + pageIndex;
            var paymentMethods = await apiClient.GetResponseAsync<PaginatedViewModel<PaymentMethod>>(query);
            return paymentMethods;
        }
        public async Task CancelOrderStatus(Guid orderNumber, string buyerName)
        {

            var query = "order/cancelOrderStatusByBuyer/"+ buyerName;
            await apiClient.PostAsync<Guid>(query, orderNumber);
        }
        public async Task CancelPaymentMethod(Guid paymentMethodId,string buyerName)
        {
            var query = "paymentMethod/cancelPaymentMethodByBuyer/"+ buyerName;
            await apiClient.PostAsync<Guid>(query, paymentMethodId);
        }
        public async Task<string> AddPaymentMethodByBuyerName(PaymentMethod paymentMethod,string userName)
        {
            paymentMethod.CardExpirationApiFormat();
            var query = "paymentMethod/addPaymentMethod/"+userName;
            var result = await apiClient.PostGetStringResponseAsync<PaymentMethod>(query,paymentMethod );
            return result; 
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
                else if (orderStatus.Name == "tamamlanildi")
                {
                    orderStatus.Name = "Tamamlanıldı";
                }
                else if (orderStatus.Name == "iptaledildi")
                {
                    orderStatus.Name = "İptal Edildi";
                }
            }
            return orderStatuses;
        }
        public async Task<List<CardType>> GetCardTypes()
        {
            var query = "paymentMethod/cardTypes";
            var cardTypes = await apiClient.GetResponseAsync<List<CardType>>(query);
            foreach (var cardType in cardTypes)
            {
                if (cardType.Name == "MasterCard")
                {
                    cardType.Name = "Master Card";
                }
            }
            return cardTypes;
        }

    }
}
