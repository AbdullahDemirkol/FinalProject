using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.Basket
{
    public class BasketItemRequest
    {
        public BasketItemRequest()
        {
            Quantity = 1;
        }
        public int ProductItemId { get; set; }
        public string BasketId { get; set; }
        public int Quantity { get; set; }

    }
}
