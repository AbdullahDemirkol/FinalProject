using BasketServiceApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.DataAccess.Abstract
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string UserName);
        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket);
        Task<bool> DeleteBasketAsync(string UserName);
        IEnumerable<string> GetUsers();
    }
}
