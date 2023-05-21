using BasketServiceApi.Business.Abstract;
using BasketServiceApi.DataAccess.PostgreSqlConnect;
using BasketServiceApi.Entity.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BasketServiceApi.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly BasketDbContext _basketDbContext;
        private readonly ILogger<BasketManager> _logger;

        public BasketManager(BasketDbContext basketDbContext, ILoggerFactory loggerFactory)
        {
            _basketDbContext = basketDbContext;
            _logger = loggerFactory.CreateLogger<BasketManager>();
        }
        public async Task<bool> DeleteBasketAsync(string username)
        {
            try
            {
                var customerBasket = await _basketDbContext.CustomerBaskets.Include(p => p.BasketItems).FirstOrDefaultAsync(p => p.UserName == username);

                if (customerBasket.BasketItems.Count > 0)
                {
                    foreach (var basketItem in customerBasket.BasketItems)
                    {
                        _basketDbContext.BasketItems.Remove(basketItem);
                    }
                }
                _basketDbContext.CustomerBaskets.Remove(customerBasket);
                await _basketDbContext.SaveChangesAsync();

                _logger.LogInformation($"{username} kullanıcıya ait sepet databaseden silindi.");
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError($"{username} kullanıcıya ait sepet databaseden silinirken hata oluştu.Hata Mesajı: {e.Message}");
                return false;
            }
        }

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket UpdateCustomerBasket)
        {
            try
            {
                if (UpdateCustomerBasket != null)
                {
                    var customerBasket = await _basketDbContext.CustomerBaskets.Include(p => p.BasketItems).FirstOrDefaultAsync(p => p.UserName == UpdateCustomerBasket.UserName);
                    if (customerBasket == null)
                    {
                        customerBasket = UpdateCustomerBasket;
                        _basketDbContext.CustomerBaskets.Add(customerBasket);
                    }
                    else
                    {
                        if (customerBasket.BasketItems.Count > 0)
                        {
                            foreach (var basketItem in customerBasket.BasketItems)
                            {
                                _basketDbContext.BasketItems.Remove(basketItem);
                            }
                        }
                        if (UpdateCustomerBasket.BasketItems.Count > 0)
                        {
                            customerBasket.BasketItems = UpdateCustomerBasket.BasketItems;
                            _basketDbContext.CustomerBaskets.Update(customerBasket);
                        }
                    }
                    await _basketDbContext.SaveChangesAsync();
                    _logger.LogInformation($"{UpdateCustomerBasket.UserName} kullanıcıya ait sepete ürün eklenildi.");
                    return await GetBasketAsync(UpdateCustomerBasket.UserName);
                }
                return await GetBasketAsync(UpdateCustomerBasket.UserName);

            }
            catch (Exception e)
            {
                _logger.LogError($"Sepete ürün eklenirken sorun oluştu.Hata Mesajı:{e.Message}");
                return await GetBasketAsync(UpdateCustomerBasket.UserName);
            }


        }
        public async Task<CustomerBasket> GetBasketAsync(string username)
        {
            var customerBasket = await _basketDbContext.CustomerBaskets.Include(p => p.BasketItems).FirstOrDefaultAsync(p => p.UserName == username);

            if (customerBasket == null)
            {
                _logger.LogInformation($"{username} kullanıcıya ait sepet bulunamadığı için yeni sepet oluşturuluyor.");
                return null;
            }
            _logger.LogInformation($"{username} kullanıcıya ait sepet getirildi.");
            return customerBasket;
        }


    }
}
