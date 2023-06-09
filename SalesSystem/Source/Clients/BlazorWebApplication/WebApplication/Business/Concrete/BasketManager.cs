﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Business.Abstract;
using WebApplication.Entity.Concrete;
using WebApplication.Entity.Concrete.Basket;
using WebApplication.Extensions.ClientHttp;

namespace WebApplication.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly HttpClient apiClient;
        private readonly IIdentityService identityService;
        private readonly ILogger<BasketManager> logger;

        public BasketManager(HttpClient apiClient, IIdentityService identityService, ILogger<BasketManager> logger)
        {
            this.apiClient = apiClient;
            this.identityService = identityService;
            this.logger = logger;
        }

        public async Task<bool> AddItemToBasket(int productId,int quantity)
        {
            var model = new BasketItemRequest
            {
                ProductItemId = productId,
                Quantity = quantity,
                BasketId = identityService.GetUsername()
            };
            var result = await apiClient.PostGetResponseAsync<bool,BasketItemRequest>("basket/addBasketItem", model);
            return result;
        }

        public Task CheckOut(BasketDTO basket)
        {
            return apiClient.PostAsync("basket/checkout", basket);
        }

        public async Task<CustomerBasket> GetBasket()
        {
            var query = "basket/" + identityService.GetUsername();
            var basket = await apiClient.GetResponseAsync<CustomerBasket>(query);
            return basket ?? new CustomerBasket() { UserName = identityService.GetUsername() };
        }

        public async Task<CustomerBasket> UpdateBasket(CustomerBasket basket)
        {
            var response = await apiClient.PostGetResponseAsync<CustomerBasket, CustomerBasket>("basket/update", basket);
            return response;
        }
    }
}
