using BasketServiceApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Business.Abstract
{
    public interface IBasketService
    {
        Task<CustomerBasket> GetBasketAsync(string username);
        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket);
        Task<bool> DeleteBasketAsync(string UserName);
        //IEnumerable<string> GetUsers();
    }
}
