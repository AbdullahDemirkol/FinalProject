using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ApiGateway.Entity.Concrete.Basket
{
    public class CustomerBasket
    {
        public CustomerBasket(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();


    }
}
