using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.ApiGateway.Business.Abstract;
using Web.ApiGateway.Entity.Concrete.Product;
using Web.ApiGateway.Extensions.ClientHttp;

namespace Web.ApiGateway.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductManager(IHttpClientFactory httpClientFactory,IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }
        public async Task<ProductItem> GetProductItemAsync(int productId)
        {
            var client = _httpClientFactory.CreateClient("product");
            var query = "product/products/" + productId;
            var response = await client.GetResponseAsync<ProductItem>(query);

            //var query2 = "picture/pictures/" + productId;
            //List<Picture> picturePaths = await client.GetResponseAsync<List<Picture>>(query2);

            return response;
        }

        public async Task<IEnumerable<ProductItem>> GetProductItemsAsync(IEnumerable<int> productIds)
        {
            List<ProductItem> products=new List<ProductItem>();
            foreach (var productId in productIds)
            {
                var client = _httpClientFactory.CreateClient("product");
                var query = "product/products/" + productId;
                var response = await client.GetResponseAsync<ProductItem>(query);
                products.Add(response);
            }
            return products;

        }
    }
}
