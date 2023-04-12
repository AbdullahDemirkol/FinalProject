using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.ApiGateway.Business.Abstract;
using Web.ApiGateway.Entity.Concrete.Basket;
using Web.ApiGateway.Extensions.ClientHttp;

namespace Web.ApiGateway.Business.Concrete
{

    public class BasketManager : IBasketService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BasketManager(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CustomerBasket> GetById(string id)
        {
            var client = _httpClientFactory.CreateClient("basket");
            var query = id;
            var response = await client.GetResponseAsync<CustomerBasket>(query);

            return response ?? new CustomerBasket(id);
        }

        public async Task<CustomerBasket> UpdateAsync(CustomerBasket basketData)
        {
            var client = _httpClientFactory.CreateClient("basket");
            var query = "update/";
            var parameter = basketData;
            var response = await client.PostGetResponseAsync<CustomerBasket, CustomerBasket>(query, parameter);
            return response;
        }
    }
}
