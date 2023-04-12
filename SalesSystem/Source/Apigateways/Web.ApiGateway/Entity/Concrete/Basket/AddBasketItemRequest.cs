using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ApiGateway.Entity.Concrete.Basket
{
    public class AddBasketItemRequest
    {
        public AddBasketItemRequest()
        {
            Quantity = 1;
        }
        public int ProductItemId { get; set; }
        public string BasketId { get; set; }
        public int Quantity { get; set; }

    }
}
