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

        public async Task<List<OrderDTO>> GetOrders(int orderStatusId)
        {
            var query = "order/orders/"+ orderStatusId;
            var orders = await apiClient.GetResponseAsync<List<OrderDTO>>(query);
            return orders;
        }
        public async Task<List<OrderDTO>> GetOrdersDetailByBuyerName(string buyerName,int orderStatusId)
        {

            var query = "order/" + buyerName+ "/OrderStatus/" + orderStatusId;
            var orders = await apiClient.GetResponseAsync<List<OrderDTO>>(query);
            return orders;
        }
        public async Task<List<PaymentMethod>> GetPaymentMethodsDetailByBuyerName(string buyerName, int cardTypeId)
        {
            var query = "paymentMethod/" + buyerName + "/CardType/" + cardTypeId;
            var paymentMethods = await apiClient.GetResponseAsync<List<PaymentMethod>>(query);
            return paymentMethods;
        }
        public async Task<List<OrderDTO>> CancelOrderStatus(Guid orderNumber)
        {

            var query = "order/cancelOrderStatus";
            var orders = await apiClient.PostGetResponseAsync<List<OrderDTO>, Guid>(query, orderNumber);
            return orders;
        }
        public async Task<List<PaymentMethod>> CancelPaymentMethod(Guid paymentMethodId)
        {
            var query = "paymentMethod/cancelPaymentMethod";
            var paymentMethods = await apiClient.PostGetResponseAsync<List<PaymentMethod>, Guid>(query, paymentMethodId);
            return paymentMethods;
        }
        public async Task<List<PaymentMethod>> AddPaymentMethod(PaymentMethod paymentMethod,string userName)
        {
            paymentMethod.CardExpirationApiFormat();
            var query = "paymentMethod/addPaymentMethod/"+userName;
            var paymentMethods = await apiClient.PostGetResponseAsync<List<PaymentMethod>, PaymentMethod>(query,paymentMethod );
            return paymentMethods;
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
        public BasketDTO MapOrderToBasket(Order order)
        {
            order.Buyer.PaymentMethod.CardExpirationApiFormat();
            var basketDto = new BasketDTO()
            {
                City = order.Address.City,
                Street = order.Address.Street,
                State = order.Address.State,
                Country = order.Address.Country,
                ZipCode = order.Address.ZipCode,
                CardNumber = order.Buyer.PaymentMethod.CardNumber,
                CardHolderName = order.Buyer.PaymentMethod.CardHolderName,
                CardExpiration = order.Buyer.PaymentMethod.Expiration,
                CardSecurityNumber = order.Buyer.PaymentMethod.SecurityNumber,
                CardTypeId = order.Buyer.PaymentMethod.CardTypeId,
                BuyerName = order.Buyer.Name
            };
            return basketDto;
        }

    }
}
