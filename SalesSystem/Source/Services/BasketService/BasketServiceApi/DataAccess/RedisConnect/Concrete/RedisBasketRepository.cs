using BasketServiceApi.DataAccess.Abstract;
using BasketServiceApi.Entity.Concrete;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.DataAccess.Concrete
{
    public class RedisBasketRepository : IBasketRepository
    {
        private readonly ILogger<RedisBasketRepository> _logger;
        private readonly ConnectionMultiplexer _connectionMultiplexer;
        private readonly IDatabase _database;

        public RedisBasketRepository(ILoggerFactory loggerFactory, ConnectionMultiplexer redis)
        {
            _logger = loggerFactory.CreateLogger<RedisBasketRepository>();
            _connectionMultiplexer = redis;
            _database = redis.GetDatabase();
        }

        public async Task<bool> DeleteBasketAsync(string UserName)
        {
            return await _database.KeyDeleteAsync(UserName);
        }

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            bool setCustomerBasket = await _database.StringSetAsync(customerBasket.UserName, JsonConvert.SerializeObject(customerBasket));
            if (!setCustomerBasket)
            {
                _logger.LogInformation("Sepet güncellenirken sorun oluştu.");
                return null;
            }
            _logger.LogInformation("Sepet başarıyla güncellenildi.");
            return await GetBasketAsync(customerBasket.UserName);
        }
        public async Task<CustomerBasket> GetBasketAsync(string UserName)
        {
            var data = await _database.StringGetAsync(UserName);

            if (data.IsNullOrEmpty)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<CustomerBasket>(data);
        }

        public IEnumerable<string> GetUsers()
        {
            var server = GetServer();
            var data = server.Keys();
            return data?.Select(p => p.ToString());
        }

        private IServer GetServer()
        {
            var endPoint = _connectionMultiplexer.GetEndPoints();
            var x = _connectionMultiplexer.GetServer(endPoint.First());
            return x;
        }
    }
}
