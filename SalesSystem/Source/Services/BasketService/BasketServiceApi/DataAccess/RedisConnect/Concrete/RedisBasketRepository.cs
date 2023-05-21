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

        public RedisBasketRepository(ILogger<RedisBasketRepository> loggerFactory, ConnectionMultiplexer redis)
        {
            _logger = loggerFactory;
            _connectionMultiplexer = redis;
            _database = redis.GetDatabase();
        }

        public async Task<bool> DeleteBasketAsync(string UserName)
        {
            var isDeleteBool = await _database.KeyDeleteAsync(UserName);
            if (isDeleteBool)
            {
                _logger.LogInformation($"{UserName} kullanıcıya ait sepet databaseden silindi.");
            }
            return isDeleteBool;
        }

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            try
            {
                bool setCustomerBasket = await _database.StringSetAsync(customerBasket.UserName, JsonConvert.SerializeObject(customerBasket));
                if (!setCustomerBasket)
                {
                    _logger.LogInformation($"{customerBasket.UserName} kullanıcıya ait sepet bulunamadığı için yeni sepet oluşturuluyor.");
                    return null;
                }
                _logger.LogInformation($"{customerBasket.UserName} kullanıcıya ait sepete ürün eklenildi.");
                return await GetBasketAsync(customerBasket.UserName);
            }
            catch (Exception e)
            {
                _logger.LogError($"{customerBasket.UserName} kullanıcıya ait sepete ürün eklenirken hata oluştu. Hata Mesajı: {e.Message}");
                return await GetBasketAsync(customerBasket.UserName);
            }
        }
        public async Task<CustomerBasket> GetBasketAsync(string UserName)
        {
            var data = await _database.StringGetAsync(UserName);

            if (data.IsNullOrEmpty)
            {
                _logger.LogInformation($"{UserName} kullanıcıya ait sepet bulunamadığı için yeni sepet oluşturuluyor.");
                return null;
            }
            _logger.LogInformation($"{UserName} kullanıcıya ait sepet getirildi.");
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
            return _connectionMultiplexer.GetServer(endPoint.First());
        }
    }
}
