using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Helper.Models
{
    public class CustomerBasket
    {
        public string UserName { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public CustomerBasket(string userName)
        {
            UserName = userName;
            BasketItems = new List<BasketItem>();
        }
    }
}
