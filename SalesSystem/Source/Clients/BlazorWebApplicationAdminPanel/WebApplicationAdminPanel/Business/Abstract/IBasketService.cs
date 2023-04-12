using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete;
using WebApplicationAdminPanel.Entity.Concrete.Basket;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IBasketService
    {
        Task<CustomerBasket> GetBasket();
        Task<CustomerBasket> UpdateBasket(CustomerBasket basket);
        Task AddItemToBasket(int productId);
        Task CheckOut(BasketDTO basket);

    }
}
