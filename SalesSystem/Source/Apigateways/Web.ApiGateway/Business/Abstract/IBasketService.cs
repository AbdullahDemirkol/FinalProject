using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ApiGateway.Entity.Concrete.Basket;

namespace Web.ApiGateway.Business.Abstract
{
    public interface IBasketService
    {
        Task<CustomerBasket> GetById(string id);
        Task<CustomerBasket> UpdateAsync(CustomerBasket basketData);
    }
}
