using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entity.Concrete;
using WebApplication.Entity.Concrete.Basket;

namespace WebApplication.Business.Abstract
{
    public interface IBasketService
    {
        Task<CustomerBasket> GetBasket();
        Task<CustomerBasket> UpdateBasket(CustomerBasket basket);
        Task AddItemToBasket(int productId);
        Task CheckOut(BasketDTO basket);

    }
}
